using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001B RID: 27
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[ComImport]
	public interface IBaseFilter
	{
		// Token: 0x060000EE RID: 238
		[PreserveSig]
		int GetClassID(out Guid pClassID);

		// Token: 0x060000EF RID: 239
		[PreserveSig]
		int Stop();

		// Token: 0x060000F0 RID: 240
		[PreserveSig]
		int Pause();

		// Token: 0x060000F1 RID: 241
		[PreserveSig]
		int Run(long tStart);

		// Token: 0x060000F2 RID: 242
		[PreserveSig]
		int GetState(int dwMilliSecsTimeout, out int filtState);

		// Token: 0x060000F3 RID: 243
		[PreserveSig]
		int SetSyncSource([In] IReferenceClock pClock);

		// Token: 0x060000F4 RID: 244
		[PreserveSig]
		int GetSyncSource(out IReferenceClock pClock);

		// Token: 0x060000F5 RID: 245
		[PreserveSig]
		int EnumPins(out IEnumPins ppEnum);

		// Token: 0x060000F6 RID: 246
		[PreserveSig]
		int FindPin([MarshalAs(UnmanagedType.LPWStr)] [In] string Id, out IPin ppPin);

		// Token: 0x060000F7 RID: 247
		[PreserveSig]
		int QueryFilterInfo([Out] FilterInfo pInfo);

		// Token: 0x060000F8 RID: 248
		[PreserveSig]
		int JoinFilterGraph([In] IFilterGraph pGraph, [MarshalAs(UnmanagedType.LPWStr)] [In] string pName);

		// Token: 0x060000F9 RID: 249
		[PreserveSig]
		int QueryVendorInfo([MarshalAs(UnmanagedType.LPWStr)] out string pVendorInfo);
	}
}
