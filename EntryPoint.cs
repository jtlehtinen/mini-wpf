using System;
using System.Windows;

[assembly:ThemeInfo(
  ResourceDictionaryLocation.None,
  ResourceDictionaryLocation.SourceAssembly
)]

namespace Mini {

  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }
  }

  public partial class App : Application {
    public App() {
      InitializeComponent();
    }

    private void InitializeComponent() {
      StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
    }
  }

  public class EntryPoint {
    [STAThread]
    public static void Main() {
      var app = new App();
      app.Run();
    }
  }
}
