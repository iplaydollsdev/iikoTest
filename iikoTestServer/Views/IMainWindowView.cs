using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iikoTestServer.Views
{
    public interface IMainWindowView
    {
        event EventHandler LoginButtonClicked;
        event EventHandler LogoutButtonClicked;
        event EventHandler FormLoaded;
        event EventHandler FormClosedCustom;

        event EventHandler Task1ButtonClicled;
        event EventHandler Task2ButtonClicked;
        event EventHandler Task3ButtonClicked;
        event EventHandler Task4ButtonClicked;

        void VisualLogin(bool isLoggedIn);
        void UpdateResponseLabel(string message);
        void LoadViewInPanel(ITaskView userControl);
    }
}
