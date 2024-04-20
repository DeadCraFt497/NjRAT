using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000057 RID: 87
	[ComVisible(true)]
	[Guid("9e5530c5-7034-48b4-bb46-0b8a6efc8e36")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IVMRFilterConfig
	{
		// Token: 0x060001DD RID: 477
		[PreserveSig]
		int SetImageCompositor([In] IntPtr lpVMRImgCompositor);

		// Token: 0x060001DE RID: 478
		[PreserveSig]
		int SetNumberOfStreams([In] uint dwMaxStreams);

		// Token: 0x060001DF RID: 479
		[PreserveSig]
		int GetNumberOfStreams(out uint pdwMaxStreams);

		// Token: 0x060001E0 RID: 480
		[PreserveSig]
		int SetRenderingPrefs([In] uint dwRenderFlags);

		// Token: 0x060001E1 RID: 481
		[PreserveSig]
		int GetRenderingPrefs(out uint pdwRenderFlags);

		// Token: 0x060001E2 RID: 482
		[PreserveSig]
		int SetRenderingMode([In] uint Mode);

		// Token: 0x060001E3 RID: 483
		[PreserveSig]
		int GetRenderingMode(out VMRMode Mode);
	}
}
