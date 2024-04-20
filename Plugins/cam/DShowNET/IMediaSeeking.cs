using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001D RID: 29
	[Guid("36b73880-c2c8-11cf-8b46-00805f6cef60")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IMediaSeeking
	{
		// Token: 0x060000FB RID: 251
		[PreserveSig]
		int GetCapabilities(ref SeekingCapabilities pCapabilities);

		// Token: 0x060000FC RID: 252
		[PreserveSig]
		int CheckCapabilities([In] [Out] ref SeekingCapabilities pCapabilities);

		// Token: 0x060000FD RID: 253
		[PreserveSig]
		int IsFormatSupported([In] ref Guid pFormat);

		// Token: 0x060000FE RID: 254
		[PreserveSig]
		int QueryPreferredFormat(out Guid pFormat);

		// Token: 0x060000FF RID: 255
		[PreserveSig]
		int GetTimeFormat(out Guid pFormat);

		// Token: 0x06000100 RID: 256
		[PreserveSig]
		int IsUsingTimeFormat([In] ref Guid pFormat);

		// Token: 0x06000101 RID: 257
		[PreserveSig]
		int SetTimeFormat([In] ref Guid pFormat);

		// Token: 0x06000102 RID: 258
		[PreserveSig]
		int GetDuration(ref long pDuration);

		// Token: 0x06000103 RID: 259
		[PreserveSig]
		int GetStopPosition(ref long pStop);

		// Token: 0x06000104 RID: 260
		[PreserveSig]
		int GetCurrentPosition(ref long pCurrent);

		// Token: 0x06000105 RID: 261
		[PreserveSig]
		int ConvertTimeFormat(ref long pTarget, [In] ref Guid pTargetFormat, long Source, [In] ref Guid pSourceFormat);

		// Token: 0x06000106 RID: 262
		[PreserveSig]
		int SetPositions([MarshalAs(UnmanagedType.LPStruct)] [In] [Out] DsOptInt64 pCurrent, SeekingFlags dwCurrentFlags, [MarshalAs(UnmanagedType.LPStruct)] [In] [Out] DsOptInt64 pStop, SeekingFlags dwStopFlags);

		// Token: 0x06000107 RID: 263
		[PreserveSig]
		int GetPositions(ref long pCurrent, ref long pStop);

		// Token: 0x06000108 RID: 264
		[PreserveSig]
		int GetAvailable(ref long pEarliest, ref long pLatest);

		// Token: 0x06000109 RID: 265
		[PreserveSig]
		int SetRate(double dRate);

		// Token: 0x0600010A RID: 266
		[PreserveSig]
		int GetRate(ref double pdRate);

		// Token: 0x0600010B RID: 267
		[PreserveSig]
		int GetPreroll(ref long pllPreroll);
	}
}
