using System.IO;

namespace WindowsExplorer.Navigator.ViewModels
{
    public class NavigatorViewModel
    {
        public List<NavigatorItemViewModel> Items { get; set; }

        public NavigatorViewModel()
        {
            var rootDirectory = new DirectoryInfo(@"C:\Users\i.tanaka\git");
            var rootNavigatorItem = new NavigatorItemViewModel(rootDirectory.Name);
            Items = new List<NavigatorItemViewModel> { rootNavigatorItem };

            CreateNavigatorItemViewModel(rootNavigatorItem, rootDirectory);
        }

        private void CreateNavigatorItemViewModel(NavigatorItemViewModel parentNavigatorItem, DirectoryInfo parentDirectory)
        {
            var directories = parentDirectory.GetDirectories();
            foreach (var directory in directories)
            {
                var navigatorItem = new NavigatorItemViewModel(directory.Name);
                parentNavigatorItem.AddChild(navigatorItem);
                CreateNavigatorItemViewModel(navigatorItem, directory);
            }
        }
    }
}
