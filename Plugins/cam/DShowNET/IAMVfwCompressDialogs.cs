using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200003D RID: 61
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D8D715A3-6E5E-11D0-B3F0-00AA003761C5")]
	[ComImport]
	public interface IAMVfwCompressDialogs
	{
		// Token: 0x06000196 RID: 406
		[PreserveSig]
		int ShowDialog([In] VfwCompressDialogs iDialog, [In] IntPtr hwnd);

		// Token: 0x06000197 RID: 407
		int GetState([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] byte[] pState, ref int pcbState);

		// Token: 0x06000198 RID: 408
		int SetState([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [In] byte[] pState, [In] int cbState);

		// Token: 0x06000199 RID: 409
		int SendDriverMessage(int uMsg, long dw1, long dw2);
	}
}
