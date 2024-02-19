using Microsoft.UI.Xaml;
using Windows.Storage;

namespace Playground;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Win32Rtb.Loaded += Win32Rtb_Loaded;
    }

    private void Win32Rtb_Loaded(object sender, RoutedEventArgs e)
    {
        
    }
}
