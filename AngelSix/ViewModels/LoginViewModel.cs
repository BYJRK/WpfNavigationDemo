using CommunityToolkit.Mvvm.Input;

namespace AngelSix.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        public string UserName { get; set; } = "AngelSix";

        [RelayCommand]
        void Login()
        {
            NavigationService.Instance.Navigate(ApplicationPage.Home);
        }
    }
}
