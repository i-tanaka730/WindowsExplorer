using WindowsExplorer.Navigator.Models;

namespace WindowsExplorer.Navigator.ViewModels;

public class NavigatorItemViewModel
{
    public Entry Entry { get; set; }

    public List<NavigatorItemViewModel> Children { get; set; }

    public string Name => Entry.Name;

    public NavigatorItemViewModel(string name)
    {
        Entry = new Entry(name);
        Children = new List<NavigatorItemViewModel>();
    }

    public void AddChild(NavigatorItemViewModel item)
    {
        Children.Add(item);
    }
}