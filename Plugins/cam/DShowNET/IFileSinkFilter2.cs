using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002D RID: 45
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("00855B90-CE1B-11d0-BD4F-00A0C911CE86")]
	[ComImport]
	public interface IFileSinkFilter2
	{
		// Token: 0x0600014B RID: 331
		[PreserveSig]
		int SetFileName([MarshalAs(UnmanagedType.LPWStr)] [In] string pszFileName, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x0600014C RID: 332
		[PreserveSig]
		int GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string pszFileName, [MarshalAs(UnmanagedType.LPStruct)] [Out] AMMediaType pmt);

		// Token: 0x0600014D RID: 333
		[PreserveSig]
		int SetMode([In] int dwFlags);

		// Token: 0x0600014E RID: 334
		[PreserveSig]
		int GetMode(out int dwFlags);
	}
}
