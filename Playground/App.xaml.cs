using Diahon.WinUI.Text;
using Microsoft.UI.Xaml;

namespace Playground;

// To learn more about WinUI 3, see https://docs.microsoft.com/windows/apps/winui/winui3/.
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        UnhandledException += App_UnhandledException;
    }

    private void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        // TODO: Log and handle exceptions as appropriate.
        // https://docs.microsoft.com/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.application.unhandledexception.
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        Win32RichEditBox rtb = new();

        MainWindow window = new();
        window.Activate();
    }
}
