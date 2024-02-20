using Microsoft.UI.Xaml.Controls;

namespace Diahon.WinUI.Text;

public sealed class RichEditCommandBarFlyout : TextCommandBarFlyout
{
    readonly AppBarButton AddTableButton = new()
    {
        Label = "Zeile hinzufügen"
    };

    public RichEditCommandBarFlyout()
    {
        Opened += OnOpened;

        AddTableButton.Click += AddTableButton_Click;
    }

    private void OnOpened(object? sender, object e)
    {
        SecondaryCommands.Add(AddTableButton);
    }

    public Win32RichEditBox? TargetRichEditBox => Target as Win32RichEditBox;

    private void AddTableButton_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        => TargetRichEditBox?.InsertTableRowAbove();
}
