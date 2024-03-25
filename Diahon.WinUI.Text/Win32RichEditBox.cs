using Microsoft.UI.Xaml.Controls;
using System.Runtime.InteropServices;
using Windows.Win32.UI.Controls.RichEdit;
using WinRT;
using ITextDocument2_Win32 = Windows.Win32.UI.Controls.RichEdit.ITextDocument2;

namespace Diahon.WinUI.Text;

public sealed class Win32RichEditBox : RichEditBox
{
    readonly ITextServices2_WinUIEdit _txtServices;
    readonly ITextDocument2_Win32 _win32Doc;
    public unsafe Win32RichEditBox()
    {
        nint pCWinRTextDocument = ((IWinRTObject)Document).NativeObject.ThisPtr;
        nint pCTxtEdit = *(nint*)(pCWinRTextDocument + 64);

        var cTxtEdit = Marshal.GetObjectForIUnknown(pCTxtEdit);
        _txtServices = (ITextServices2_WinUIEdit)cTxtEdit;
        _win32Doc = (ITextDocument2_Win32)cTxtEdit;
    }

    ITextRange2 SelectionRange
    {
        get
        {
            _win32Doc.GetSelection(out var selection).ThrowOnFailure();
            return (ITextRange2)selection;
        }
    }

    public void InsertTableRowAbove(int rowCount = 1)
    {
        var range = SelectionRange;
        range.GetDuplicate2(out range).ThrowOnFailure();

        range.Expand((int)tomConstants.tomRow, out _).ThrowOnFailure();

        // Insert above
        range.GetStart(out var position).ThrowOnFailure();
        range.SetStart(position).ThrowOnFailure();
        range.SetEnd(position).ThrowOnFailure();

        range.GetRow(out var row).ThrowOnFailure();
        row.Insert(rowCount).ThrowOnFailure();
    }
}
