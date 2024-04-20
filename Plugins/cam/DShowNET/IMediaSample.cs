using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000025 RID: 37
	[Guid("56a8689a-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IMediaSample
	{
		// Token: 0x06000119 RID: 281
		[PreserveSig]
		int GetPointer(ref IntPtr ppBuffer);

		// Token: 0x0600011A RID: 282
		[PreserveSig]
		int GetSize();

		// Token: 0x0600011B RID: 283
		[PreserveSig]
		int GetTime(ref long pTimeStart, ref long pTimeEnd);

		// Token: 0x0600011C RID: 284
		[PreserveSig]
		int SetTime([MarshalAs(UnmanagedType.LPStruct)] [In] DsOptInt64 pTimeStart, [MarshalAs(UnmanagedType.LPStruct)] [In] DsOptInt64 pTimeEnd);

		// Token: 0x0600011D RID: 285
		[PreserveSig]
		int IsSyncPoint();

		// Token: 0x0600011E RID: 286
		[PreserveSig]
		int SetSyncPoint([MarshalAs(UnmanagedType.Bool)] [In] bool bIsSyncPoint);

		// Token: 0x0600011F RID: 287
		[PreserveSig]
		int IsPreroll();

		// Token: 0x06000120 RID: 288
		[PreserveSig]
		int SetPreroll([MarshalAs(UnmanagedType.Bool)] [In] bool bIsPreroll);

		// Token: 0x06000121 RID: 289
		[PreserveSig]
		int GetActualDataLength();

		// Token: 0x06000122 RID: 290
		[PreserveSig]
		int SetActualDataLength(int len);

		// Token: 0x06000123 RID: 291
		[PreserveSig]
		int GetMediaType([MarshalAs(UnmanagedType.LPStruct)] out AMMediaType ppMediaType);

		// Token: 0x06000124 RID: 292
		[PreserveSig]
		int SetMediaType([MarshalAs(UnmanagedType.LPStruct)] [In] AMMediaType pMediaType);

		// Token: 0x06000125 RID: 293
		[PreserveSig]
		int IsDiscontinuity();

		// Token: 0x06000126 RID: 294
		[PreserveSig]
		int SetDiscontinuity([MarshalAs(UnmanagedType.Bool)] [In] bool bDiscontinuity);

		// Token: 0x06000127 RID: 295
		[PreserveSig]
		int GetMediaTime(ref long pTimeStart, ref long pTimeEnd);

		// Token: 0x06000128 RID: 296
		[PreserveSig]
		int SetMediaTime([MarshalAs(UnmanagedType.LPStruct)] [In] DsOptInt64 pTimeStart, [MarshalAs(UnmanagedType.LPStruct)] [In] DsOptInt64 pTimeEnd);
	}
}
