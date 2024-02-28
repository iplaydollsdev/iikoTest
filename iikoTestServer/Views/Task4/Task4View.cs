using iikoTestServer.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iikoTestServer.Views
{
    public partial class Task4View : UserControl, ITask4View
    {
        public Task4View()
        {
            InitializeComponent();
            ingredientsListBox.View = View.List;
        }

        public void ShowRecipe(string name, List<ProductModel> ingredients)
        {
            recipeNameText.Text = name;
            ingredientsListBox.Items.Clear();
            foreach (var i in ingredients) 
            {
                ingredientsListBox.Items.Add(i.Name);
            }
        }
    }
}
