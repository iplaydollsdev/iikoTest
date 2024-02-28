

using iikoTestServer.Models.Task4;
using System.Collections.Generic;

namespace iikoTestServer.Models
{
    public class Task4Model
    {
        public string RecipeName { get; set; }
        public ChartResultModel ChartResult { get; set; }
        public List<ProductModel> Ingredients { get; set; }


    }
}
