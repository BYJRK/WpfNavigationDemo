namespace Kevin;

public abstract class PageViewModelBase : ViewModelBase
{
    public string? Header { get; set; }
}

public class Page1ViewModel : PageViewModelBase
{
    public Page1ViewModel() => Header = "Page 1";

    public string PageMessage { get; set; } = "Hello, Page 1";
}

public class Page2ViewModel : PageViewModelBase
{
    public Page2ViewModel() => Header = "Page 2";

    public string PageMessage { get; set; } = "Hello, Page 2";
}

public class Page3ViewModel : PageViewModelBase
{
    public Page3ViewModel() => Header = "Page 3";

    public string PageMessage { get; set; } = "Hello, Page 3";
}
