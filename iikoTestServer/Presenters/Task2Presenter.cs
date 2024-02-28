using iikoTestServer.Data;
using iikoTestServer.Models;
using iikoTestServer.Views;

namespace iikoTestServer.Presenters
{
    public class Task2Presenter
    {
        private ITask2View _view;
        private Task2Model _model;
        private IDataService _dataService;

        public Task2Presenter(ITask2View view, Task2Model model, IDataService dataService)
        {
            _view = view;
            _model = model;
            _dataService = dataService;

            _view.ShowProduct(_model.ProductForRequest);

            _view.UpdateProductButtonClicked += View_UpdateProductButtonClicked;
            _view.NameTextChanged += View_NameTextChanged;
        }

        private void View_NameTextChanged(object text, System.EventArgs e)
        {
            _model.ProductForRequest.Name = (string)text;
        }

        private async void View_UpdateProductButtonClicked(object sender, System.EventArgs e)
        {
            var errorDto = await _dataService.UpdateProduct(_model.ProductForRequest);
            if (errorDto != null && errorDto.Result != "ERROR") 
            {
                var newResponseDto = await _dataService.GetProductDto(_model.ProductForRequest.Id);
                _model = new Task2Model(newResponseDto);
                _view.ShowProduct(_model.ProductForRequest);
                _view.NameChanged(_model.ProductForRequest.Name);
            }
        }
    }
}
