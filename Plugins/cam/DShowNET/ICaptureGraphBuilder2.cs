using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200002A RID: 42
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("93E5A4E0-2D50-11d2-ABFA-00A0C9C6E38D")]
	[ComImport]
	public interface ICaptureGraphBuilder2
	{
		// Token: 0x06000131 RID: 305
		[PreserveSig]
		int SetFiltergraph([In] IGraphBuilder pfg);

		// Token: 0x06000132 RID: 306
		[PreserveSig]
		int GetFiltergraph(out IGraphBuilder ppfg);

		// Token: 0x06000133 RID: 307
		[PreserveSig]
		int SetOutputFileName([In] ref Guid pType, [MarshalAs(UnmanagedType.LPWStr)] [In] string lpstrFile, out IBaseFilter ppbf, out IFileSinkFilter ppSink);

		// Token: 0x06000134 RID: 308
		[PreserveSig]
		int FindInterface([In] ref Guid pCategory, [In] ref Guid pType, [In] IBaseFilter pbf, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppint);

		// Token: 0x06000135 RID: 309
		[PreserveSig]
		int RenderStream([In] ref Guid pCategory, [In] ref Guid pType, [MarshalAs(UnmanagedType.IUnknown)] [In] object pSource, [In] IBaseFilter pfCompressor, [In] IBaseFilter pfRenderer);

		// Token: 0x06000136 RID: 310
		[PreserveSig]
		int ControlStream([In] ref Guid pCategory, [In] ref Guid pType, [In] IBaseFilter pFilter, [In] long pstart, [In] long pstop, [In] short wStartCookie, [In] short wStopCookie);

		// Token: 0x06000137 RID: 311
		[PreserveSig]
		int AllocCapFile([MarshalAs(UnmanagedType.LPWStr)] [In] string lpstrFile, [In] long dwlSize);

		// Token: 0x06000138 RID: 312
		[PreserveSig]
		int CopyCaptureFile([MarshalAs(UnmanagedType.LPWStr)] [In] string lpwstrOld, [MarshalAs(UnmanagedType.LPWStr)] [In] string lpwstrNew, [In] int fAllowEscAbort, [In] IAMCopyCaptureFileProgress pFilter);

		// Token: 0x06000139 RID: 313
		[PreserveSig]
		int FindPin([In] object pSource, [In] int pindir, [In] ref Guid pCategory, [In] ref Guid pType, [MarshalAs(UnmanagedType.Bool)] [In] bool fUnconnected, [In] int num, out IPin ppPin);
	}
}
