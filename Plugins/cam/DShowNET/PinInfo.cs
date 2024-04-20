using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000024 RID: 36
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	public struct PinInfo
	{
		// Token: 0x040000B0 RID: 176
		public IBaseFilter filter;

		// Token: 0x040000B1 RID: 177
		public PinDirection dir;

		// Token: 0x040000B2 RID: 178
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string name;
	}
}
