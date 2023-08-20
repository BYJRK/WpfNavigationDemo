using SingletonSean.ViewModels;
using System.Windows;

namespace SingletonSean
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public static new App Current => (App)Application.Current;

        public App()
        {
            var container = new ServiceCollection();

            container.AddSingleton<MainWindow>();
            container.AddSingleton<MainViewModel>();

            container.AddSingleton<NavigationService>();
            container.AddSingleton<UserService>();

            container.AddTransient<LoginViewModel>();
            container.AddTransient<HomeViewModel>();

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }
}
