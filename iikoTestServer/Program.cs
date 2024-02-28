using System;
using System.Windows.Forms;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using iikoTestServer.Data;
using iikoTestServer.Views;

namespace iikoTestServer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    ServiceCollection services = new ServiceCollection();
        //    services.AddHttpClient();
        //    ServiceProvider serviceProvider = services.BuildServiceProvider();

        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new MainWindow(serviceProvider.GetRequiredService<IHttpClientFactory>()));
        //}
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    var services = new ServiceCollection();
        //    services.AddHttpClient(); // Register IHttpClientFactory in the service collection
        //    var serviceProvider = services.BuildServiceProvider();

        //    var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();

        //    var mainWindowModel = new MainWindowModel(httpClientFactory);
        //    var mainWindow = new MainWindow();
        //    var presenter = new MainPresenter(mainWindow, mainWindowModel);
        //    Application.Run(mainWindow);
        //}
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            // Регистрация служб в контейнере зависимостей
            services.AddHttpClient(); // Регистрация IHttpClientFactory в контейнере служб

            // Зарегистрируйте представление и другие службы
            services.AddScoped<IMainWindowView, MainWindow>(); // Зарегистрируйте интерфейс IMainWindowView с реализацией MainWindow как службу
            //services.AddScoped<IDataService, DataService>(); // Зарегистрируйте DataService как службу
            services.AddSingleton<IDataService, DataService>();

            var serviceProvider = services.BuildServiceProvider();

            // Получение необходимых сервисов из контейнера
            var mainWindow = serviceProvider.GetRequiredService<IMainWindowView>(); // Получите экземпляр представления из контейнера
            var dataService = serviceProvider.GetRequiredService<IDataService>(); // Получите экземпляр DataService из контейнера

            // Создание и запуск презентера для главного окна
            var presenter = new MainWindowPresenter(mainWindow, dataService);

            Application.Run((mainWindow as Form)); // Запуск главной очереди сообщений приложения
        }

    }
}
