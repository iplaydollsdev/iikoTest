using System.Collections.Generic;

namespace iikoTestServer.Models.Task3
{
    public class Task3Model
    {
        public List<EmployeesSalaryModel> Salaries {  get; private set; }

        public Task3Model(List<EmployeesSalaryModel> salaries)
        {
            Salaries = salaries;
        }
    }
}
