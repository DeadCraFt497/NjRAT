using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000045 RID: 69
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
	[ComImport]
	public interface ISpecifyPropertyPages
	{
		// Token: 0x060001A9 RID: 425
		[PreserveSig]
		int GetPages(ref DsCAUUID pPages);
	}
}
