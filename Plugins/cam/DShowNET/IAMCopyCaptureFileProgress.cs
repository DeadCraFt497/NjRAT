using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002E RID: 46
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("670d1d20-a068-11d0-b3f0-00aa003761c5")]
	[ComImport]
	public interface IAMCopyCaptureFileProgress
	{
		// Token: 0x0600014F RID: 335
		[PreserveSig]
		int Progress(int iProgress);
	}
}
