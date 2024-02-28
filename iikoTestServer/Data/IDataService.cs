using iikoTestServer.Models;
using iikoTestServer.Models.Task3;
using iikoTestServer.Models.Task4;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace iikoTestServer.Data
{
    public interface IDataService
    {
        Task<List<AccountModel>> GetAllEntities();
        Task<string> GetProducts();
        Task<ProductModel> GetProductById(string id);
        Task<ChartResultModel> GetRecipe(string id);
        Task Login(string login, string password);
        Task Logout();
        Task<List<EmployeesSalaryModel>> GetAllEmployeesSalary();
        Task<bool> PostSalary(string id, decimal salary);
        Task<HttpResponseMessage> SendRequestWithQueryParameters(HttpMethod method, string endpoint, Dictionary<string, string> queryParameters);
        Task<string> UpdateProduct();
    }
}