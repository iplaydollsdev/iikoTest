using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Models
{
    public class AccountModel
    {
        public string RootType { get; set; }
        public string Id { get; set; }
        public bool Deleted { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string AccountParentId { get; set; }
        public string ParentCorporateId { get; set; }
        public string Type { get; set; }
        public bool System { get; set; }
        public bool CustomTransactionsAllowed { get; set; }
    }

}
