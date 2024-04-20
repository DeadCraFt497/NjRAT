using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET.Device
{
	// Token: 0x02000029 RID: 41
	[Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[ComImport]
	public interface IPropertyBag
	{
		// Token: 0x0600012F RID: 303
		[PreserveSig]
		int Read([MarshalAs(UnmanagedType.LPWStr)] [In] string pszPropName, [MarshalAs(UnmanagedType.Struct)] [In] [Out] ref object pVar, IntPtr pErrorLog);

		// Token: 0x06000130 RID: 304
		[PreserveSig]
		int Write([MarshalAs(UnmanagedType.LPWStr)] [In] string pszPropName, [MarshalAs(UnmanagedType.Struct)] [In] ref object pVar);
	}
}
