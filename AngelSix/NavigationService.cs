using AngelSix.ViewModels;

namespace AngelSix
{
    class NavigationService
    {
        public static NavigationService Instance { get; } = new NavigationService();

        private MainViewModel mainVM;

        public void Navigate(ApplicationPage page)
        {
            if (mainVM == null)
            {
                mainVM = (MainViewModel)App.Current.MainWindow.DataContext;
            }

            mainVM.CurrentPage = page;
        }
    }
}
