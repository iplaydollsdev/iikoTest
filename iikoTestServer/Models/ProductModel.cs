using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iikoTestServer.Models
{
    public partial class ProductModel
    {
        public string Id { get; set; }
        public bool Deleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Parent { get; set; }
        public ModifierModel[] Modifiers { get; set; }
        public Decimal DefaultSalePrice { get; set; }
        public string Type {  get; set; }
    }
}
