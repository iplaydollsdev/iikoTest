using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iikoTestServer.Models.ProductModel;

namespace iikoTestServer.Views
{
    public interface ITask2ProductView
    {
        public string ProductId { get; set; }
        public bool IsProductDeleted { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductNum { get; set; }
        public string ProductCode { get; set; }
        public string ProductParent { get; set; }
        public ModifierModel[] Modifiers { get; set; }
        public Decimal ProductDefaultSalePrice { get; set; }
        public string ProductType { get; set; }


        event EventHandler GetEvent;
        event EventHandler UpdateEvent;

        void SetProductListBindingSource(BindingSource productList);
    }
}
