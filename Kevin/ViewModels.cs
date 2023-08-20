namespace Kevin;

public class Page1ViewModel : ViewModelBase
{
    public string Header { get; } = "Page 1";

    public string PageMessage { get; set; } = "Hello, Page 1";
}

public class Page2ViewModel : ViewModelBase
{
    public string Header { get; } = "Page 2";

    public string PageMessage { get; set; } = "Hello, Page 2";
}

public class Page3ViewModel : ViewModelBase
{
    public string Header { get; } = "Page 3";

    public string PageMessage { get; set; } = "Hello, Page 3";
}
