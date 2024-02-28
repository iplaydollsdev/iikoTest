using iikoTestServer.Data;
using iikoTestServer.Models.Task3;
using iikoTestServer.Views.Task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Presenters
{
    public class Task3Presenter
    {
        private readonly ITask3View _view;
        private readonly IDataService _dataService;
        private readonly Task3Model _model;

        public Task3Presenter(ITask3View view, Task3Model model, IDataService dataService)
        {
            _view = view;
            _model = model;
            _dataService = dataService;

            _view.SetSalaryButtonClicked += View_SetSalaryButtonClicked;

            LoadEntitiesWithCustomTransactionsAllowed();
        }

        private void View_SetSalaryButtonClicked(object sender, EventArgs e)
        {
            // TODO: Replace hardcoded args after testing testing
            _dataService.PostSalary(_model.Salaries.FirstOrDefault().EmployeeId, 400);
        }

        private void LoadEntitiesWithCustomTransactionsAllowed()
        {
            var salary = _model.Salaries.FirstOrDefault();
            _view.ShowSalary(salary);
        }
    }
}
