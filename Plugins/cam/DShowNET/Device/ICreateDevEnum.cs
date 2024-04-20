using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET.Device
{
	// Token: 0x02000028 RID: 40
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
	[ComVisible(true)]
	[ComImport]
	public interface ICreateDevEnum
	{
		// Token: 0x0600012E RID: 302
		[PreserveSig]
		int CreateClassEnumerator([In] ref Guid pType, out UCOMIEnumMoniker ppEnumMoniker, [In] int dwFlags);
	}
}
