using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000053 RID: 83
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8f537d09-f85e-4414-b23b-502e54c79927")]
	[ComVisible(true)]
	[ComImport]
	public interface IVMRWindowlessControl9
	{
		// Token: 0x060001C1 RID: 449
		int GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);

		// Token: 0x060001C2 RID: 450
		int GetMinIdealVideoSize(out int lpHeight);

		// Token: 0x060001C3 RID: 451
		int GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);

		// Token: 0x060001C4 RID: 452
		int SetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] [In] RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] [In] RECT lpDSTRect);

		// Token: 0x060001C5 RID: 453
		int GetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] out RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] out RECT lpDSTRect);

		// Token: 0x060001C6 RID: 454
		int GetAspectRatioMode(out VMR9AspectRatioMode lpAspectRatioMode);

		// Token: 0x060001C7 RID: 455
		int SetAspectRatioMode([In] VMR9AspectRatioMode AspectRatioMode);

		// Token: 0x060001C8 RID: 456
		int SetVideoClippingWindow([In] IntPtr hwnd);

		// Token: 0x060001C9 RID: 457
		int RepaintVideo([In] IntPtr hwnd, [In] IntPtr hdc);

		// Token: 0x060001CA RID: 458
		int DisplayModeChanged();

		// Token: 0x060001CB RID: 459
		int GetCurrentImage(out IntPtr lpDib);

		// Token: 0x060001CC RID: 460
		int SetBorderColor([In] uint Clr);

		// Token: 0x060001CD RID: 461
		int GetBorderColor(out uint lpClr);
	}
}
