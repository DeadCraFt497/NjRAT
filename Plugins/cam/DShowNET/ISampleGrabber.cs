using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200005D RID: 93
	[ComVisible(true)]
	[Guid("6B652FFF-11FE-4fce-92AD-0266B5D7C78F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface ISampleGrabber
	{
		// Token: 0x060001FC RID: 508
		[PreserveSig]
		int SetOneShot([MarshalAs(UnmanagedType.Bool)] [In] bool OneShot);

		// Token: 0x060001FD RID: 509
		[PreserveSig]
		int SetMediaType([MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x060001FE RID: 510
		[PreserveSig]
		int GetConnectedMediaType([MarshalAs(UnmanagedType.LPStruct)] [Out] AMMediaType pmt);

		// Token: 0x060001FF RID: 511
		[PreserveSig]
		int SetBufferSamples([MarshalAs(UnmanagedType.Bool)] [In] bool BufferThem);

		// Token: 0x06000200 RID: 512
		[PreserveSig]
		int GetCurrentBuffer(ref int pBufferSize, IntPtr pBuffer);

		// Token: 0x06000201 RID: 513
		[PreserveSig]
		int GetCurrentSample(IntPtr ppSample);

		// Token: 0x06000202 RID: 514
		[PreserveSig]
		int SetCallback(ISampleGrabberCB pCallback, int WhichMethodToCallback);
	}
}
