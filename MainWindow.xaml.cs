using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
namespace TechECS {
    public partial class MainWindow : Window {
        public MainWindow() { this.InitializeComponent(); NavTechECS.SelectedItem = MenuAlias; }
        private void NavTechECS_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            if (args.SelectedItemContainer is NavigationViewItem item) {
                if (item.Name == "MenuAlias") ContentFrame.Navigate(typeof(AliasManagerPage));
                if (item.Name == "MenuBackups") ContentFrame.Navigate(typeof(BackupManagerPage));
            }
        }
    }
}
