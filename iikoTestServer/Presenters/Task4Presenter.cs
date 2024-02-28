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
    public class Task4Presenter
    {
        private Task4Model _model;
        private ITask4View _view;
        private IDataService _dataService;

        public Task4Presenter(Task4Model task4Model, ITask4View task4View, IDataService dataService)
        {
            _model = task4Model;
            _view = task4View;
            _dataService = dataService;

            _ = SetModel();
        }

        private async Task SetModel()
        {
            // Caesar
            string recipeId = "66d99615-14fc-473d-b1e3-a18d51e7fe9b";
            var recipe = await _dataService.GetRecipe(recipeId);
            var recipeProduct = await _dataService.GetProductsById(recipeId);

            var productsIds = new List<string>();
            foreach (var item in recipe.PreparedCharts[0].Items)
            {
                productsIds.Add(item.ProductId);
            }
            var products = await _dataService.GetProductsById(productsIds.ToArray());

            _model.RecipeName = recipeProduct.FirstOrDefault().Name;
            _model.ChartResult = recipe;
            _model.Ingredients = products;

            ShowRecipe();
        }

        private void ShowRecipe()
        {
            _view.ShowRecipe(_model.RecipeName, _model.Ingredients);
        }
    }
}
