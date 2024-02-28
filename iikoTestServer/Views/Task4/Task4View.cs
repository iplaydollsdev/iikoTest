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
    public partial class Task4View : UserControl, ITask1View
    {
        public Task4View()
        {
            InitializeComponent();
        }

        public void ShowEntities(List<AccountModel> entities)
        {
        }
    }
}
