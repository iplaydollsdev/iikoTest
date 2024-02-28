using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Models
{
    public class Task1Model
    {
        public List<AccountModel> Entities { get; private set; }

        public Task1Model(List<AccountModel> entities)
        {
            Entities = entities;
        }
    }
}
