using System.Collections.Generic;

namespace Kevin
{
    public class MainViewModel : ViewModelBase
    {
        public List<ViewModelBase> ViewModels { get; }

        public MainViewModel(Page1ViewModel p1, Page2ViewModel p2, Page3ViewModel p3)
        {
            ViewModels = new List<ViewModelBase> { p1, p2, p3 };
        }
    }
}
