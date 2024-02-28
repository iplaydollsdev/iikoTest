using Resto.Front.Api;
using Resto.Front.Api.Attributes;

namespace iikoTestPlugin
{
    [PluginLicenseModuleId(21005108)]
    public class TestPlugin : IFrontPlugin
    {
        private readonly List<IDisposable> _subscriptions = new List<IDisposable>();

        public TestPlugin() 
        {
            // Выводим текст при инициализации плагина
            ShowNotificationMessage("Message on the loading screen...");

            // Добавляем кнопку в меню плагинов для вывода сообщения
            _subscriptions.Add(PluginContext.Operations.AddButtonToPluginsMenu("Test Notification", _ => ShowNotificationMessage("Message on the button press...")));
        }

        /// <summary>
        /// Выводим сообщение в iikoFront
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        private void ShowNotificationMessage(string message)
        {
            PluginContext.Operations.AddNotificationMessage(message, "TestPlugin");
        }

        public void Dispose()
        {
            foreach (IDisposable subscription in _subscriptions)
            {
                subscription.Dispose();
            }
        }
    }
}
