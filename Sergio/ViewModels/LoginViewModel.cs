using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;

namespace Sergio.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;

        public string UserName { get; set; } = "Sergio";

        public LoginViewModel(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        [RelayCommand]
        void Login()
        {
            navigationService.Navigate<HomeViewModel>(new Dictionary<string, object?>
            {
                [nameof(HomeViewModel.UserName)] = UserName
            });
        }
    }
}
