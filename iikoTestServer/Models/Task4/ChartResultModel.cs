using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Models.Task4
{
    public class ChartResultModel
    {
        public int KnownRevision { get; set; }
        public Preparedchart[] PreparedCharts { get; set; }
    }


    public class Preparedchart
    {
        public string Id { get; set; }
        public string AssembledProductId { get; set; }
        public Item[] Items { get; set; }
    }


    public class Item
    {
        public string Id { get; set; }
        public float SortWeight { get; set; }
        public string ProductId { get; set; }
        public float Amount { get; set; }
    }
}
