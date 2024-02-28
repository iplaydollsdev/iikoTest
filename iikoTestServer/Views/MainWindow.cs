using iikoTestServer.Views;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace iikoTestServer
{
    public partial class MainWindow : Form, IMainWindowView
    {
        public event EventHandler LoginButtonClicked;
        public event EventHandler LogoutButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler FormClosedCustom;

        public event EventHandler Task1ButtonClicled;
        public event EventHandler Task2ButtonClicked;
        public event EventHandler Task3ButtonClicked;
        public event EventHandler Task4ButtonClicked;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void UpdateResponseLabel(string text)
        {
            loginLabel.Text = text;
        }

        public void VisualLogin(bool isLoggedIn)
        {
            logoutButton.Enabled = isLoggedIn;
            loginButton.Enabled = !isLoggedIn;

            if (isLoggedIn)
            {
                taskButton1.Enabled = true;
                taskButton2.Enabled = true;
                taskButton3.Enabled = true;
                taskButton4.Enabled = true;
                controlContainerPanel.Visible = true;
                loginImage.Image = Properties.Resources.greenIcon;
                loginLabel.Text = "Logged In";
            }
            else
            {
                taskButton1.Enabled = false;
                taskButton2.Enabled = false;
                taskButton3.Enabled = false;
                taskButton4.Enabled = false;
                controlContainerPanel.Visible = false;
                loginImage.Image = Properties.Resources.redIcon;
                loginLabel.Text = "Logged Out";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LogoutButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke(this, EventArgs.Empty);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedCustom?.Invoke(this, EventArgs.Empty);
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor(taskButton1);
            Task1ButtonClicled?.Invoke(this, EventArgs.Empty);
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor(taskButton2);
            Task2ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void TaskButton3_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor(taskButton3);
            Task3ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void TaskButton4_Click(object sender, EventArgs e)
        {
            ChangeButtonsColor(taskButton4);
            Task4ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void LoadViewInPanel(ITaskView view)
        {
            controlContainerPanel.Controls.Clear();
            controlContainerPanel.Controls.Add(view as UserControl);
        }

        private void ChangeButtonsColor(Button pressedButton)
        {
            Button[] taskButtons = { taskButton1, taskButton2, taskButton3, taskButton4 };

            foreach (var button in taskButtons)
            {
                if (button != pressedButton)
                {
                    button.BackColor = Color.Gray;
                }
                else
                {
                    button.BackColor = DefaultBackColor;
                }
            }
        }
    }

}
