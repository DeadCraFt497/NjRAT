using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000016 RID: 22
	[ComVisible(true)]
	[Guid("56a86891-0ad4-11ce-b03a-0020af0ba770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IPin
	{
		// Token: 0x060000CE RID: 206
		[PreserveSig]
		int Connect([In] IPin pReceivePin, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x060000CF RID: 207
		[PreserveSig]
		int ReceiveConnection([In] IPin pReceivePin, [MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x060000D0 RID: 208
		[PreserveSig]
		int Disconnect();

		// Token: 0x060000D1 RID: 209
		[PreserveSig]
		int ConnectedTo(out IPin ppPin);

		// Token: 0x060000D2 RID: 210
		[PreserveSig]
		int ConnectionMediaType([MarshalAs(UnmanagedType.LPStruct)] [Out] AMMediaType pmt);

		// Token: 0x060000D3 RID: 211
		[PreserveSig]
		int QueryPinInfo(out PinInfo pInfo);

		// Token: 0x060000D4 RID: 212
		[PreserveSig]
		int QueryDirection(ref PinDirection pPinDir);

		// Token: 0x060000D5 RID: 213
		[PreserveSig]
		int QueryId([MarshalAs(UnmanagedType.LPWStr)] out string Id);

		// Token: 0x060000D6 RID: 214
		[PreserveSig]
		int QueryAccept([MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pmt);

		// Token: 0x060000D7 RID: 215
		[PreserveSig]
		int EnumMediaTypes(IntPtr ppEnum);

		// Token: 0x060000D8 RID: 216
		[PreserveSig]
		int QueryInternalConnections(IntPtr apPin, [In] [Out] ref int nPin);

		// Token: 0x060000D9 RID: 217
		[PreserveSig]
		int EndOfStream();

		// Token: 0x060000DA RID: 218
		[PreserveSig]
		int BeginFlush();

		// Token: 0x060000DB RID: 219
		[PreserveSig]
		int EndFlush();

		// Token: 0x060000DC RID: 220
		[PreserveSig]
		int NewSegment(long tStart, long tStop, double dRate);
	}
}
