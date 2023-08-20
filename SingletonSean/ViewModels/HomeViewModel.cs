using CommunityToolkit.Mvvm.Input;

namespace SingletonSean.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;

        [ObservableProperty]
        string? userName;

        public HomeViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
            UserName = userService.UserName;
        }

        [RelayCommand]
        void Logout()
        {
            // navigate back to login page
            userService.UserName = null;
            navigationService.NavigateTo<LoginViewModel>();
        }
    }
}
