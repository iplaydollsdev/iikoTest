using iikoTestServer;
using System.Threading.Tasks;
using System;
using iikoTestServer.Views;
using iikoTestServer.Data;
using iikoTestServer.Models;
using iikoTestServer.Presenters;
using iikoTestServer.Views.Task3;
using iikoTestServer.Models.Task3;

public class MainWindowPresenter
{
    private readonly IMainWindowView _view;
    private readonly IDataService _dataService;

    public MainWindowPresenter(IMainWindowView view, IDataService dataService)
    {
        _view = view;
        _dataService = dataService;

        _view.LoginButtonClicked += async (sender, args) => await Login();
        _view.LogoutButtonClicked += async (sender, args) => await Logout();
        _view.FormLoaded += (sender, args) => OnFormLoaded();
        _view.FormClosedCustom += (sender, args) => OnFormClosed();

        _view.Task1ButtonClicled += View_Task1ButtonClicled;
        _view.Task3ButtonClicked += View_Task3ButtonClicked;
        _view.Task4ButtonClicked += View_Task4ButtonClicked;
    }

    private async void View_Task1ButtonClicled(object sender, EventArgs e)
    {
        var entities = await _dataService.GetAllEntities();
        ITask1View task1View = new Task1View();
        Task1Model task1Model = new(entities);
        Task1Presenter task1Presenter = new(task1View, task1Model);
        _view.LoadViewInPanel(task1View);
    }

    private async void View_Task3ButtonClicked(object sender, EventArgs e)
    {
        var salaries = await _dataService.GetAllEmployeesSalary();
        ITask3View task3View = new Task3View();
        Task3Model task3Model = new(salaries);
        Task3Presenter task3Presenter = new(task3View, task3Model, _dataService);
        _view.LoadViewInPanel(task3View);
    }

    private async void View_Task4ButtonClicked(object sender, EventArgs e)
    {
        var recipes = await _dataService.GetRecipe("66d99615-14fc-473d-b1e3-a18d51e7fe9b");
        var testProduct = await _dataService.GetProductById(recipes.PreparedCharts[0].Items[0].ProductId);
    }

    private async Task Login()
    {
        try
        {
            await _dataService.Login("user", "user#test");
            var response = await _dataService.GetProducts();
            _view.UpdateResponseLabel(response);
            _view.VisualLogin(isLoggedIn: true);
        }
        catch (Exception ex)
        {
            _view.UpdateResponseLabel(ex.Message);
        }
    }

    private async Task Logout()
    {
        try
        {
            await _dataService.Logout();
            _view.VisualLogin(isLoggedIn: false);
        }
        catch (Exception ex)
        {
            _view.UpdateResponseLabel(ex.Message);
        }
    }

    private async void OnFormLoaded()
    {
        await Login();
    }

    private void OnFormClosed()
    {
        _ = Logout();
    }
}
