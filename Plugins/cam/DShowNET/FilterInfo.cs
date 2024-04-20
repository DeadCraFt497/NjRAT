using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200001C RID: 28
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class FilterInfo
	{
		// Token: 0x04000091 RID: 145
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string achName;

		// Token: 0x04000092 RID: 146
		[MarshalAs(UnmanagedType.IUnknown)]
		public object pUnk;
	}
}
