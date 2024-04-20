using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000023 RID: 35
	[ComVisible(false)]
	[StructLayout(LayoutKind.Sequential)]
	public class AMMediaType
	{
		// Token: 0x040000A7 RID: 167
		public Guid majorType;

		// Token: 0x040000A8 RID: 168
		public Guid subType;

		// Token: 0x040000A9 RID: 169
		[MarshalAs(UnmanagedType.Bool)]
		public bool fixedSizeSamples;

		// Token: 0x040000AA RID: 170
		[MarshalAs(UnmanagedType.Bool)]
		public bool temporalCompression;

		// Token: 0x040000AB RID: 171
		public int sampleSize;

		// Token: 0x040000AC RID: 172
		public Guid formatType;

		// Token: 0x040000AD RID: 173
		public IntPtr unkPtr;

		// Token: 0x040000AE RID: 174
		public int formatSize;

		// Token: 0x040000AF RID: 175
		public IntPtr formatPtr;
	}
}
