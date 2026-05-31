using Microsoft.UI.Xaml;
namespace TechECS {
    public partial class App : Application {
        public static Window? MainWindowInstance { get; private set; }
        public App() { this.InitializeComponent(); }
        protected override void OnLaunched(LaunchActivatedEventArgs args) {
            var window = new MainWindow(); MainWindowInstance = window; window.Activate();
        }
    }
}
