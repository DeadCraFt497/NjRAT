using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000050 RID: 80
	[ComVisible(false)]
	public enum VMRMode9 : uint
	{
		// Token: 0x04000145 RID: 325
		Windowed = 1U,
		// Token: 0x04000146 RID: 326
		Windowless,
		// Token: 0x04000147 RID: 327
		Renderless = 4U
	}
}
