using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000017 RID: 23
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a8689f-0ad4-11ce-b03a-0020af0ba770")]
	[ComImport]
	public interface IFilterGraph
	{
		// Token: 0x060000DD RID: 221
		[PreserveSig]
		int AddFilter([In] IBaseFilter pFilter, [MarshalAs(UnmanagedType.LPWStr)] [In] string pName);

		// Token: 0x060000DE RID: 222
		[PreserveSig]
		int RemoveFilter([In] IBaseFilter pFilter);

		// Token: 0x060000DF RID: 223
		[PreserveSig]
		int EnumFilters(out IEnumFilters ppEnum);

		// Token: 0x060000E0 RID: 224
		[PreserveSig]
		int FindFilterByName([MarshalAs(UnmanagedType.LPWStr)] [In] string pName, out IBaseFilter ppFilter);

		// Token: 0x060000E1 RID: 225
		[PreserveSig]
		int ConnectDirect([In] IPin ppinOut, [In] IPin ppinIn, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x060000E2 RID: 226
		[PreserveSig]
		int Reconnect([In] IPin ppin);

		// Token: 0x060000E3 RID: 227
		[PreserveSig]
		int Disconnect([In] IPin ppin);

		// Token: 0x060000E4 RID: 228
		[PreserveSig]
		int SetDefaultSyncSource();
	}
}
