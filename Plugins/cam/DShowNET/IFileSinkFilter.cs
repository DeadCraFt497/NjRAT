using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002C RID: 44
	[ComVisible(true)]
	[Guid("a2104830-7c70-11cf-8bce-00aa00a3f1a6")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IFileSinkFilter
	{
		// Token: 0x06000149 RID: 329
		[PreserveSig]
		int SetFileName([MarshalAs(UnmanagedType.LPWStr)] [In] string pszFileName, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x0600014A RID: 330
		[PreserveSig]
		int GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string pszFileName, [MarshalAs(UnmanagedType.LPStruct)] [Out] AMMediaType pmt);
	}
}
