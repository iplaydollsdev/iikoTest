using iikoTestServer.Data;
using iikoTestServer.Models;
using iikoTestServer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Presenters
{
    public class Task1Presenter
    {
        private readonly ITask1View _view;
        private readonly Task1Model _model;

        public Task1Presenter(ITask1View view, Task1Model model)
        {
            _view = view;
            _model = model;

            LoadEntitiesWithCustomTransactionsAllowed();
        }

        private void LoadEntitiesWithCustomTransactionsAllowed()
        {
            var entities = _model.Entities.Where(e => e.CustomTransactionsAllowed == true).ToList();
            _view.ShowEntities(entities);
        }
    }
}
