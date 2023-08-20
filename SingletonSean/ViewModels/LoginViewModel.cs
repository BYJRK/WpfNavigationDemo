using CommunityToolkit.Mvvm.Input;

namespace SingletonSean.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;

        [ObservableProperty]
        string? userName = "Sean";

        public LoginViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
        }

        [RelayCommand]
        void Login()
        {
            // navigate to home page
            userService.UserName = UserName;
            navigationService.NavigateTo<HomeViewModel>();
        }
    }
}
