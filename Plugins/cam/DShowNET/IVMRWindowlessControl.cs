using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000056 RID: 86
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7")]
	[ComImport]
	public interface IVMRWindowlessControl
	{
		// Token: 0x060001CE RID: 462
		int GetNativeVideoSize(out int lpWidth, out int lpHeight, out int lpARWidth, out int lpARHeight);

		// Token: 0x060001CF RID: 463
		int GetMinIdealVideoSize(out int lpHeight);

		// Token: 0x060001D0 RID: 464
		int GetMaxIdealVideoSize(out int lpWidth, out int lpHeight);

		// Token: 0x060001D1 RID: 465
		int SetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] [In] RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] [In] RECT lpDSTRect);

		// Token: 0x060001D2 RID: 466
		int GetVideoPosition([MarshalAs(UnmanagedType.LPStruct)] out RECT lpSRCRect, [MarshalAs(UnmanagedType.LPStruct)] out RECT lpDSTRect);

		// Token: 0x060001D3 RID: 467
		int GetAspectRatioMode(out uint lpAspectRatioMode);

		// Token: 0x060001D4 RID: 468
		int SetAspectRatioMode([In] uint AspectRatioMode);

		// Token: 0x060001D5 RID: 469
		int SetVideoClippingWindow([In] IntPtr hwnd);

		// Token: 0x060001D6 RID: 470
		int RepaintVideo([In] IntPtr hwnd, [In] IntPtr hdc);

		// Token: 0x060001D7 RID: 471
		int DisplayModeChanged();

		// Token: 0x060001D8 RID: 472
		int GetCurrentImage(out IntPtr lpDib);

		// Token: 0x060001D9 RID: 473
		int SetBorderColor([In] uint Clr);

		// Token: 0x060001DA RID: 474
		int GetBorderColor(out uint lpClr);

		// Token: 0x060001DB RID: 475
		int SetColorKey([In] uint Clr);

		// Token: 0x060001DC RID: 476
		int GetColorKey(out uint lpClr);
	}
}
