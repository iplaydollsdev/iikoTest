using iikoTestServer.Models;
using iikoTestServer.Models.Task3;
using iikoTestServer.Views.Task3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iikoTestServer.Views
{
    public partial class Task3View : UserControl, ITask3View
    {
        public Task3View()
        {
            InitializeComponent();
        }

        public event EventHandler SetSalaryButtonClicked;

        public void ShowSalary(EmployeesSalaryModel salaryModel)
        {
            employeeIdText.Text = salaryModel.EmployeeId;
            oldSalaryText.Text = salaryModel.Payment.ToString();
        }

        private void SetNewSalaryButton_Click(object sender, EventArgs e)
        {
            SetSalaryButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
