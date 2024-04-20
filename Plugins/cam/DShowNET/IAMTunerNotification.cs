using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000036 RID: 54
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("211A8760-03AC-11d1-8D13-00AA00BD8339")]
	[ComImport]
	public interface IAMTunerNotification
	{
		// Token: 0x06000166 RID: 358
		[PreserveSig]
		int OnEvent(AMTunerEventType Event);
	}
}
