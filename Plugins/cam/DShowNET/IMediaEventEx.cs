using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000C RID: 12
	[Guid("56a868c0-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComImport]
	public interface IMediaEventEx
	{
		// Token: 0x06000069 RID: 105
		[PreserveSig]
		int GetEventHandle(ref IntPtr hEvent);

		// Token: 0x0600006A RID: 106
		[PreserveSig]
		int GetEvent(ref DsEvCode lEventCode, ref int lParam1, ref int lParam2, int msTimeout);

		// Token: 0x0600006B RID: 107
		[PreserveSig]
		int WaitForCompletion(int msTimeout, out int pEvCode);

		// Token: 0x0600006C RID: 108
		[PreserveSig]
		int CancelDefaultHandling(int lEvCode);

		// Token: 0x0600006D RID: 109
		[PreserveSig]
		int RestoreDefaultHandling(int lEvCode);

		// Token: 0x0600006E RID: 110
		[PreserveSig]
		int FreeEventParams(DsEvCode lEvCode, int lParam1, int lParam2);

		// Token: 0x0600006F RID: 111
		[PreserveSig]
		int SetNotifyWindow(IntPtr hwnd, int lMsg, IntPtr lInstanceData);

		// Token: 0x06000070 RID: 112
		[PreserveSig]
		int SetNotifyFlags(int lNoNotifyFlags);

		// Token: 0x06000071 RID: 113
		[PreserveSig]
		int GetNotifyFlags(ref int lplNoNotifyFlags);
	}
}
