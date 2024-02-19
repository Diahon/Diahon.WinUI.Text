using Microsoft.UI.Xaml.Controls;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Controls.RichEdit;
using WinRT;
using static Windows.Win32.PInvoke;
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

    public unsafe void InsertTableRow()
    {
        _win32Doc.GetSelection(out var selection);
        var range = (ITextRange2)selection;

        range.GetDuplicate2(out range);

        range.StartOf((int)tomConstants.tomRow, (int)tomConstants.tomExtend, out _);
        range.EndOf((int)tomConstants.tomRow, (int)tomConstants.tomExtend, out _);

        // Insert above
        range.GetStart(out var position);
        range.SetStart(position);
        range.SetEnd(position);

        range.GetRow(out var row);

        row.Insert(1);
    }
}
