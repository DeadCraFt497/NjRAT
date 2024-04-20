using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000052 RID: 82
	[Guid("5a804648-4f66-4867-9c43-4f5c822cf1b8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[ComImport]
	public interface IVMRFilterConfig9
	{
		// Token: 0x060001BA RID: 442
		[PreserveSig]
		int SetImageCompositor([In] IntPtr lpVMRImgCompositor);

		// Token: 0x060001BB RID: 443
		[PreserveSig]
		int SetNumberOfStreams([In] uint dwMaxStreams);

		// Token: 0x060001BC RID: 444
		[PreserveSig]
		int GetNumberOfStreams(out uint pdwMaxStreams);

		// Token: 0x060001BD RID: 445
		[PreserveSig]
		int SetRenderingPrefs([In] uint dwRenderFlags);

		// Token: 0x060001BE RID: 446
		[PreserveSig]
		int GetRenderingPrefs(out uint pdwRenderFlags);

		// Token: 0x060001BF RID: 447
		[PreserveSig]
		int SetRenderingMode([In] VMRMode9 Mode);

		// Token: 0x060001C0 RID: 448
		[PreserveSig]
		int GetRenderingMode(out VMRMode9 Mode);
	}
}
