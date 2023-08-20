namespace SingletonSean.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        [ObservableProperty]
        private ViewModelBase? currentViewModel;

        public MainViewModel(NavigationService navigationService)
        {
            navigator = navigationService;

            navigator.CurrentViewModelChanged += () =>
            {
                CurrentViewModel = navigationService.CurrentViewModel;
            };

            // navigate to login page at first
            navigator.NavigateTo<LoginViewModel>();
        }
    }
}
