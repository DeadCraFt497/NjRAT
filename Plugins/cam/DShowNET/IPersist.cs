using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000018 RID: 24
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010c-0000-0000-C000-000000000046")]
	[ComImport]
	public interface IPersist
	{
		// Token: 0x060000E5 RID: 229
		[PreserveSig]
		int GetClassID(out Guid pClassID);
	}
}
