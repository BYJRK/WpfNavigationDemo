using AngelSix.ViewModels;
using System.Windows.Controls;

namespace AngelSix
{
    public abstract class BasePage<VM> : UserControl where VM : ViewModelBase, new()
    {
        public BasePage()
        {
            DataContext = new VM();
        }
    }
}
