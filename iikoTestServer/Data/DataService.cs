using iikoTestServer.Models;
using iikoTestServer.Models.Task3;
using iikoTestServer.Models.Task4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace iikoTestServer.Data
{
    public class DataService : IDataService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private const string BaseUrl = "https://demo-bez-kompanii.iiko.it:443/resto/api/";
        //private const string BaseUrl = "https://avi-study77-co.iiko.it:443/resto/api/";

        private string _authToken;

        public DataService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task Login(string login, string password)
        {
            var sha1PasswordHash = CalculateSHA1Hash(password);
            var requestUri = $"{BaseUrl}auth?login={login}&pass={sha1PasswordHash}";
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(requestUri);
            if (response.IsSuccessStatusCode)
            {
                _authToken = await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception("Failed to get authentication token");
            }
        }

        public async Task Logout()
        {
            var requestUri = $"{BaseUrl}logout?key={_authToken}";
            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(requestUri);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to logout");
            }
            _authToken = null;
        }

        private string CalculateSHA1Hash(string input)
        {
            using (var sha1 = System.Security.Cryptography.SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha1.ComputeHash(inputBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public async Task<List<AccountModel>> GetAllEntities()
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "rootType", "Account" },
                { "key", _authToken }
            };

            var response = await SendRequestWithQueryParameters(HttpMethod.Get, "v2/entities/list", queryParameters);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<AccountModel>>();
            }
            else
            {
                return null;
            }
        }

        public async Task<List<ProductModel>> GetProductsById(params string[] ids)
        {
            var idsString = string.Join("&ids=", ids);
            var queryParameters = new Dictionary<string, string>
            {
                { "includeDeleted", "false" },
                { "key", _authToken }
            };

            var queryString = $"?ids={idsString}";

            var response = await SendRequestWithQueryParameters(HttpMethod.Get, "v2/entities/products/list" + queryString, queryParameters);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ProductModel>>();
            }
            else
            {
                return null;
            }
        }

        public async Task<List<EmployeesSalaryModel>> GetAllEmployeesSalary()
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "key", _authToken }
            };

            var response = await SendRequestWithQueryParameters(HttpMethod.Get, "v2/employees/salary", queryParameters);
            if (response.IsSuccessStatusCode)
            {
                var xmlString = await response.Content.ReadAsStringAsync();

                var serializer = new XmlSerializer(typeof(SalariesWrapper));
                using (var reader = new StringReader(xmlString))
                {
                    var salariesWrapper = (SalariesWrapper)serializer.Deserialize(reader);
                    return salariesWrapper.Salaries;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> PostSalary(string id, decimal salary)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "payment", salary.ToString() },
                { "key", _authToken }
            };
            var date = DateTime.Now.ToString("yyyy-MM-dd");

            var response = await SendRequestWithQueryParameters(HttpMethod.Post, $"employees/salary/byId/{id}/{date}", queryParameters);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<ErrorDto> UpdateProduct(ProductRequestDto productDto)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "overrideFastCode", "true" },
                { "overrideNomenclatureCode", "true" },
                { "key", _authToken }
            };

            var content = JsonContent.Create(productDto);
            var response = await SendRequestWithQueryParameters(HttpMethod.Post, "v2/entities/products/update", queryParameters, content);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ErrorDto>();
            }
            else
            {
                return null;
            }
        }

        public async Task<ProductResponseDto> GetProductDto(string id)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "includeDeleted", "false" },
                { "ids", id },
                { "key", _authToken }
            };

            var response = await SendRequestWithQueryParameters(HttpMethod.Get, "v2/entities/products/list", queryParameters);
            if (response.IsSuccessStatusCode)
            {
                var productDtos = await response.Content.ReadFromJsonAsync<List<ProductResponseDto>>();
                return productDtos.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public async Task<ChartResultModel> GetRecipe(string id)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "date", "2024-02-28" },
                { "productId", id },
                { "key", _authToken }
            };

            var response = await SendRequestWithQueryParameters(HttpMethod.Get, "v2/assemblyCharts/getPrepared", queryParameters);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ChartResultModel>();
            }
            else
            {
                return null;
            }
        }

        public async Task<HttpResponseMessage> SendRequestWithQueryParameters(HttpMethod method, string endpoint, Dictionary<string, string> queryParameters, HttpContent content = null)
        {
            var client = _httpClientFactory.CreateClient();

            var uriBuilder = new UriBuilder($"{BaseUrl}{endpoint}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            foreach (var parameter in queryParameters)
            {
                query[parameter.Key] = parameter.Value;
            }

            uriBuilder.Query = query.ToString();

            var request = new HttpRequestMessage(method, uriBuilder.Uri);
            if (content != null)
                request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);

            return response;
        }
    }
}
