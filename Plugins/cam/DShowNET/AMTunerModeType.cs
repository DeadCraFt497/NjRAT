using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000033 RID: 51
	[ComVisible(false)]
	[Flags]
	public enum AMTunerModeType
	{
		// Token: 0x040000BD RID: 189
		Default = 0,
		// Token: 0x040000BE RID: 190
		TV = 1,
		// Token: 0x040000BF RID: 191
		FMRadio = 2,
		// Token: 0x040000C0 RID: 192
		AMRadio = 4,
		// Token: 0x040000C1 RID: 193
		Dss = 8
	}
}
