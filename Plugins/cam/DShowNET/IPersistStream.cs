using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000019 RID: 25
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010c-0000-0000-C000-000000000046")]
	[ComVisible(true)]
	[ComImport]
	public interface IPersistStream
	{
		// Token: 0x060000E6 RID: 230
		[PreserveSig]
		int GetClassID(out Guid pClassID);
	}
}
