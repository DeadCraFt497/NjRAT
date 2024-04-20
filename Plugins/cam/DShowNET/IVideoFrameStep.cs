using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002F RID: 47
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e46a9787-2b71-444d-a4b5-1fab7b708d6a")]
	[ComVisible(true)]
	[ComImport]
	public interface IVideoFrameStep
	{
		// Token: 0x06000150 RID: 336
		[PreserveSig]
		int Step(int dwFrames, [MarshalAs(UnmanagedType.IUnknown)] [In] object pStepObject);

		// Token: 0x06000151 RID: 337
		[PreserveSig]
		int CanStep(int bMultiple, [MarshalAs(UnmanagedType.IUnknown)] [In] object pStepObject);

		// Token: 0x06000152 RID: 338
		[PreserveSig]
		int CancelStep();
	}
}
