using WindowsExplorer.Navigator.ViewModels;

namespace WindowsExplorer.Windows.ViewModels;

public class MainWindowViewModel
{
    public NavigatorViewModel NavigatorViewModel { get; set; }

    public MainWindowViewModel()
    {
        NavigatorViewModel = new NavigatorViewModel();
    }
}