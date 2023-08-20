using SingletonSean.ViewModels;

namespace SingletonSean
{
    public class NavigationService
    {
        private ViewModelBase? currentViewModel;

        public ViewModelBase? CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                // notify property changed
                CurrentViewModelChanged?.Invoke();
            }
        }

        public event Action? CurrentViewModelChanged;

        public void NavigateTo<T>() where T : ViewModelBase
            => CurrentViewModel = App.Current.Services.GetService<T>();
    }
}
