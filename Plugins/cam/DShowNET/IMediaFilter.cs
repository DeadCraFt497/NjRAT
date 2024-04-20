using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001A RID: 26
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComVisible(true)]
	[Guid("56a86899-0ad4-11ce-b03a-0020af0ba770")]
	[ComImport]
	public interface IMediaFilter
	{
		// Token: 0x060000E7 RID: 231
		[PreserveSig]
		int GetClassID(out Guid pClassID);

		// Token: 0x060000E8 RID: 232
		[PreserveSig]
		int Stop();

		// Token: 0x060000E9 RID: 233
		[PreserveSig]
		int Pause();

		// Token: 0x060000EA RID: 234
		[PreserveSig]
		int Run(long tStart);

		// Token: 0x060000EB RID: 235
		[PreserveSig]
		int GetState(int dwMilliSecsTimeout, ref int filtState);

		// Token: 0x060000EC RID: 236
		[PreserveSig]
		int SetSyncSource([In] IReferenceClock pClock);

		// Token: 0x060000ED RID: 237
		[PreserveSig]
		int GetSyncSource(out IReferenceClock pClock);
	}
}
