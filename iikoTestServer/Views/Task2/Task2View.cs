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
    public partial class Task2View : UserControl, ITask2View
    {
        public Task2View()
        {
            InitializeComponent();
        }

        public event EventHandler UpdateProductButtonClicked;
        public event EventHandler NameTextChanged;

        public void NameChanged(string name)
        {
            MessageBox.Show($"Name was changed to {name}");
        }

        public void ShowProduct(ProductRequestDto product)
        {
            productIdText.Text = product.Id;
            oldNameText.Text = product.Name;
            newNameInput.Text = product.Name;
        }

        private void NewNameInput_TextChanged(object text, EventArgs e)
        {
            NameTextChanged?.Invoke(newNameInput.Text, e);
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            UpdateProductButtonClicked?.Invoke(this, e);
        }
    }
}
