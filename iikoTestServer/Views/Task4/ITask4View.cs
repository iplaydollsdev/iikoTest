using iikoTestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iikoTestServer.Views
{
    public interface ITask4View : ITaskView
    {
        void ShowRecipe(string name, List<ProductModel> ingredients);
    }
}
