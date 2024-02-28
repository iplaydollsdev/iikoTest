using iikoTestServer.Models;
using System;

namespace iikoTestServer.Views
{
    public interface ITask2View : ITaskView
    {
        void ShowProduct(ProductRequestDto product);
        void NameChanged(string name);
        event EventHandler UpdateProductButtonClicked;
        event EventHandler NameTextChanged;
    }
}
