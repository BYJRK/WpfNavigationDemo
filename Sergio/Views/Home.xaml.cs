using Sergio.ViewModels;
using System.Windows.Controls;

namespace Sergio
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home : Page
    {
        public Home(HomeViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
