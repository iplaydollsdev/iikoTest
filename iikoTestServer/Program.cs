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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddHttpClient();

            services.AddScoped<IMainWindowView, MainWindow>();
            services.AddSingleton<IDataService, DataService>();

            var serviceProvider = services.BuildServiceProvider();

            var mainWindow = serviceProvider.GetRequiredService<IMainWindowView>();
            var dataService = serviceProvider.GetRequiredService<IDataService>();

            var presenter = new MainWindowPresenter(mainWindow, dataService);

            Application.Run((mainWindow as Form));
        }

    }
}
