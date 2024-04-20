using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000030 RID: 48
	[Guid("C6E13340-30AC-11d0-A18C-00A0C9118956")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[ComImport]
	public interface IAMStreamConfig
	{
		// Token: 0x06000153 RID: 339
		[PreserveSig]
		int SetFormat([MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x06000154 RID: 340
		[PreserveSig]
		int GetFormat(out IntPtr pmt);

		// Token: 0x06000155 RID: 341
		[PreserveSig]
		int GetNumberOfCapabilities(ref int piCount, ref int piSize);

		// Token: 0x06000156 RID: 342
		[PreserveSig]
		int GetStreamCaps(int iIndex, out IntPtr pmt, [In] IntPtr pSCC);
	}
}
