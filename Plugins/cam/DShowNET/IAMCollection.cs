using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000011 RID: 17
	[ComVisible(true)]
	[Guid("56a868b9-0ad4-11ce-b03a-0020af0ba770")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComImport]
	public interface IAMCollection
	{
		// Token: 0x060000C9 RID: 201
		[PreserveSig]
		int get_Count(ref int plCount);

		// Token: 0x060000CA RID: 202
		[PreserveSig]
		int Item(int lItem, [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);

		// Token: 0x060000CB RID: 203
		[PreserveSig]
		int get_NewEnum([MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
	}
}
