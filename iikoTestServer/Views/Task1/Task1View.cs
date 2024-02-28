using iikoTestServer.Models;
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
    public partial class Task1View : UserControl, ITask1View
    {
        public Task1View()
        {
            InitializeComponent();
        }

        public void ShowEntities(List<AccountModel> entities)
        {
            entitiesDropdown.Items.Clear();
            foreach (AccountModel entity in entities)
            {
                entitiesDropdown.Items.Add(entity.Name);
            }
            entitiesDropdown.SelectedIndex = 0;
        }
    }
}
