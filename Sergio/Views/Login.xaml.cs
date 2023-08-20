using Sergio.ViewModels;
using System.Windows.Controls;

namespace Sergio
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Page
    {
        public Login(LoginViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
