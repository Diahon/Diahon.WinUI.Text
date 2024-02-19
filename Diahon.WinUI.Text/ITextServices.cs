using System.Runtime.InteropServices;
using winmdroot = Windows.Win32;

namespace Diahon.WinUI.Text;

[Guid("8d33f741-cf58-11ce-a89d-00aa006cadc5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITextServices2_WinUIEdit
{
    unsafe void TxSendMessage(uint msg, winmdroot.Foundation.WPARAM wparam, winmdroot.Foundation.LPARAM lparam, winmdroot.Foundation.LRESULT* plresult);

    unsafe void TxDraw(winmdroot.System.Com.DVASPECT dwDrawAspect, int lindex, void* pvAspect, winmdroot.System.Com.DVTARGETDEVICE* ptd, winmdroot.Graphics.Gdi.HDC hdcDraw, winmdroot.Graphics.Gdi.HDC hicTargetDev, winmdroot.Foundation.RECTL* lprcBounds, winmdroot.Foundation.RECTL* lprcWBounds, winmdroot.Foundation.RECT* lprcUpdate, nint pfnContinue, uint dwContinue, int lViewId);

    unsafe void TxGetHScroll(ref int plMin, ref int plMax, ref int plPos, ref int plPage, winmdroot.Foundation.BOOL* pfEnabled);

    unsafe void TxGetVScroll(ref int plMin, ref int plMax, ref int plPos, ref int plPage, winmdroot.Foundation.BOOL* pfEnabled);

    unsafe void OnTxSetCursor(winmdroot.System.Com.DVASPECT dwDrawAspect, int lindex, void* pvAspect, winmdroot.System.Com.DVTARGETDEVICE* ptd, winmdroot.Graphics.Gdi.HDC hdcDraw, winmdroot.Graphics.Gdi.HDC hicTargetDev, winmdroot.Foundation.RECT* lprcClient, int x, int y);

    unsafe void TxQueryHitPoint(winmdroot.System.Com.DVASPECT dwDrawAspect, int lindex, void* pvAspect, winmdroot.System.Com.DVTARGETDEVICE* ptd, winmdroot.Graphics.Gdi.HDC hdcDraw, winmdroot.Graphics.Gdi.HDC hicTargetDev, winmdroot.Foundation.RECT* lprcClient, int x, int y, ref uint pHitResult);

    unsafe void OnTxInPlaceActivate(winmdroot.Foundation.RECT* prcClient);

    void OnTxInPlaceDeactivate();

    void OnTxUIActivate();

    void OnTxUIDeactivate();

    unsafe void TxGetText(winmdroot.Foundation.BSTR* pbstrText);

    void TxSetText(winmdroot.Foundation.PCWSTR pszText);

    void TxGetCurTargetX(ref int param0);

    void TxGetBaseLinePos(ref int param0);

    unsafe void TxGetNaturalSize(uint dwAspect, winmdroot.Graphics.Gdi.HDC hdcDraw, winmdroot.Graphics.Gdi.HDC hicTargetDev, winmdroot.System.Com.DVTARGETDEVICE* ptd, uint dwMode, winmdroot.Foundation.SIZE* psizelExtent, ref int pwidth, ref int pheight);

    void TxGetDropTarget(out winmdroot.System.Ole.IDropTarget ppDropTarget);

    void OnTxPropertyBitsChange(uint dwMask, uint dwBits);

    void TxGetCachedSize(ref uint pdwWidth, ref uint pdwHeight);

    /// <summary>Resizes a control so it fits its content appropriately. This method is similar to TxGetNaturalSize, but also retrieves the ascent of the top line of text.</summary>
    /// <param name="dwAspect">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">DWORD</a></b> The aspect for the drawing. It can be any of the values from the <a href="https://docs.microsoft.com/windows/desktop/api/wtypes/ne-wtypes-dvaspect">DVASPECT</a> enumeration.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hdcDraw">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HDC</a></b> The device context into which drawing occurs.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="hicTargetDev">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HDC</a></b> The device context for which text should be formatted (that is, for WYSIWYG).</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="ptd">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/objidl/ns-objidl-dvtargetdevice">DVTARGETDEVICE</a>*</b> More information on the target device.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="dwMode">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">DWORD</a></b> The type of fitting requested. It can be one of the following. </para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="psizelExtent">
    /// <para>Type: <b>const SIZEL*</b> Sizes of extents (in HIMETRIC units) to use for zooming.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pwidth">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LONG</a>*</b> The width for the fitting defined by <i>dwMode</i>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pheight">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LONG</a>*</b> The height for the fitting defined by <i>dwMode</i>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="pascent">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LONG</a>*</b> For single-line controls, receives the ascent (units above the baseline) of characters in the top line of text.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HRESULT</a></b> If the method succeeds, the return value is <b>S_OK</b>. If text services could not activate the object, the return value is one of the following <b>HRESULT</b> codes. For more information on COM error codes, see <a href="https://docs.microsoft.com/windows/desktop/com/error-handling-in-com">Error Handling in COM</a>. </para>
    /// <para>This doc was truncated.</para>
    /// </returns>
    /// <remarks>
    /// <para>The first four parameters are similar to equivalent parameters in <a href="https://docs.microsoft.com/windows/desktop/api/textserv/nf-textserv-itextservices-txdraw">ITextServices::TxDraw</a> and give the same information. In the case where the lines must be recalculated, <b>TxGetNaturalSize2</b>  uses these values in the same ways as in <b>ITextServices::TxDraw</b>. The <i>pwidth</i> and <i>pheight</i> parameters are in/out parameters. The host passes in the tentative width and height of the natural extent of the text object. The text services object compares these values against its current cached state, and if different, recalculates lines. Then, it computes and returns the natural size, as specified by <i>dwMode</i>.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txgetnaturalsize2#">Read more on docs.microsoft.com</see>.</para>
    /// </remarks>
    unsafe void TxGetNaturalSize2(uint dwAspect, winmdroot.Graphics.Gdi.HDC hdcDraw, winmdroot.Graphics.Gdi.HDC hicTargetDev, winmdroot.System.Com.DVTARGETDEVICE* ptd, uint dwMode, winmdroot.Foundation.SIZE* psizelExtent, ref int pwidth, ref int pheight, ref int pascent);

    /// <summary>Draws the text services object by using Direct2D rendering.</summary>
    /// <param name="pRenderTarget">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/d2d1/nn-d2d1-id2d1rendertarget">ID2D1RenderTarget</a>*</b> The Direct2D rendering object that draws the text services object.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="lprcBounds">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/win32/api/windef/ns-windef-rectl">LPCRECTL</a></b> The bounding (client) rectangle.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="lprcUpdate">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">LPRECT</a></b> The rectangle to update inside <i>lprcBounds</i> rectangle, in the logical coordinate system of drawing device context. If this parameter is NULL, the entire client rectangle should be drawn.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <param name="lViewId">
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">LONG</a></b> The view to draw. </para>
    /// <para>This doc was truncated.</para>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d#parameters">Read more on docs.microsoft.com</see>.</para>
    /// </param>
    /// <returns>
    /// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/WinProg/windows-data-types">HRESULT</a></b> If this method succeeds, it returns <b>S_OK</b>. Otherwise, it returns an <b>HRESULT</b> error code.</para>
    /// </returns>
    /// <remarks>
    /// <para><see href="https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-itextservices2-txdrawd2d">Learn more about this API from docs.microsoft.com</see>.</para>
    /// </remarks>
    unsafe void TxDrawD2D(winmdroot.Graphics.Direct2D.ID2D1RenderTarget pRenderTarget, winmdroot.Foundation.RECTL* lprcBounds, winmdroot.Foundation.RECT* lprcUpdate, int lViewId);
}
