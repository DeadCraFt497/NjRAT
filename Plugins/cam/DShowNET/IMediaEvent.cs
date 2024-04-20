using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000B RID: 11
	[Guid("56a868b6-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComImport]
	public interface IMediaEvent
	{
		// Token: 0x06000063 RID: 99
		[PreserveSig]
		int GetEventHandle(ref IntPtr hEvent);

		// Token: 0x06000064 RID: 100
		[PreserveSig]
		int GetEvent(ref DsEvCode lEventCode, ref int lParam1, ref int lParam2, int msTimeout);

		// Token: 0x06000065 RID: 101
		[PreserveSig]
		int WaitForCompletion(int msTimeout, ref int pEvCode);

		// Token: 0x06000066 RID: 102
		[PreserveSig]
		int CancelDefaultHandling(int lEvCode);

		// Token: 0x06000067 RID: 103
		[PreserveSig]
		int RestoreDefaultHandling(int lEvCode);

		// Token: 0x06000068 RID: 104
		[PreserveSig]
		int FreeEventParams(DsEvCode lEvCode, int lParam1, int lParam2);
	}
}
