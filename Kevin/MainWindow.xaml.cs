using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Kevin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel vm)
        {
            InitializeComponent();

            this.DataContext = vm;

            //Page1.DataContext = App.Current.Services.GetRequiredService<Page1ViewModel>();
            //Page2.DataContext = App.Current.Services.GetRequiredService<Page2ViewModel>();
            //Page3.DataContext = App.Current.Services.GetRequiredService<Page3ViewModel>();
        }
    }
}
