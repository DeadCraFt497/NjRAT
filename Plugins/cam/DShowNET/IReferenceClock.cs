using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000020 RID: 32
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a86897-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[ComImport]
	public interface IReferenceClock
	{
		// Token: 0x0600010C RID: 268
		[PreserveSig]
		int GetTime(ref long pTime);

		// Token: 0x0600010D RID: 269
		[PreserveSig]
		int AdviseTime(long baseTime, long streamTime, IntPtr hEvent, ref int pdwAdviseCookie);

		// Token: 0x0600010E RID: 270
		[PreserveSig]
		int AdvisePeriodic(long startTime, long periodTime, IntPtr hSemaphore, ref int pdwAdviseCookie);

		// Token: 0x0600010F RID: 271
		[PreserveSig]
		int Unadvise(int dwAdviseCookie);
	}
}
