using iikoTestServer.Models.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Views.Task3
{
    public interface ITask3View : ITaskView
    {
        public void ShowSalary(EmployeesSalaryModel salaryModel);
        event EventHandler SetSalaryButtonClicked;
    }
}
