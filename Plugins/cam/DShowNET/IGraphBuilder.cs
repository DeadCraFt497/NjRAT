using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002B RID: 43
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[ComImport]
	public interface IGraphBuilder
	{
		// Token: 0x0600013A RID: 314
		[PreserveSig]
		int AddFilter([In] IBaseFilter pFilter, [MarshalAs(UnmanagedType.LPWStr)] [In] string pName);

		// Token: 0x0600013B RID: 315
		[PreserveSig]
		int RemoveFilter([In] IBaseFilter pFilter);

		// Token: 0x0600013C RID: 316
		[PreserveSig]
		int EnumFilters(out IEnumFilters ppEnum);

		// Token: 0x0600013D RID: 317
		[PreserveSig]
		int FindFilterByName([MarshalAs(UnmanagedType.LPWStr)] [In] string pName, out IBaseFilter ppFilter);

		// Token: 0x0600013E RID: 318
		[PreserveSig]
		int ConnectDirect([In] IPin ppinOut, [In] IPin ppinIn, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x0600013F RID: 319
		[PreserveSig]
		int Reconnect([In] IPin ppin);

		// Token: 0x06000140 RID: 320
		[PreserveSig]
		int Disconnect([In] IPin ppin);

		// Token: 0x06000141 RID: 321
		[PreserveSig]
		int SetDefaultSyncSource();

		// Token: 0x06000142 RID: 322
		[PreserveSig]
		int Connect([In] IPin ppinOut, [In] IPin ppinIn);

		// Token: 0x06000143 RID: 323
		[PreserveSig]
		int Render([In] IPin ppinOut);

		// Token: 0x06000144 RID: 324
		[PreserveSig]
		int RenderFile([MarshalAs(UnmanagedType.LPWStr)] [In] string lpcwstrFile, [MarshalAs(UnmanagedType.LPWStr)] [In] string lpcwstrPlayList);

		// Token: 0x06000145 RID: 325
		[PreserveSig]
		int AddSourceFilter([MarshalAs(UnmanagedType.LPWStr)] [In] string lpcwstrFileName, [MarshalAs(UnmanagedType.LPWStr)] [In] string lpcwstrFilterName, out IBaseFilter ppFilter);

		// Token: 0x06000146 RID: 326
		[PreserveSig]
		int SetLogFile(IntPtr hFile);

		// Token: 0x06000147 RID: 327
		[PreserveSig]
		int Abort();

		// Token: 0x06000148 RID: 328
		[PreserveSig]
		int ShouldOperationContinue();
	}
}
