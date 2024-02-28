using iikoTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Views
{
    public interface ITask1View : ITaskView
    {
        void ShowEntities(List<AccountModel> entities);
    }
}
