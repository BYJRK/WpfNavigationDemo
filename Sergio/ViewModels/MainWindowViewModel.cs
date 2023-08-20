using CommunityToolkit.Mvvm.Input;

namespace Sergio.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;

        public MainWindowViewModel(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        [RelayCommand]
        void Loaded()
        {
            navigationService.Navigate<LoginViewModel>();
        }
    }
}
