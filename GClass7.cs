using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NJRAT
{
	// Token: 0x02000034 RID: 52
	public sealed class GClass7
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00145984 File Offset: 0x00143D84
		[DebuggerNonUserCode]
		public GClass7()
		{
		}

		// Token: 0x060005BB RID: 1467
		[DllImport("User32.dll")]
		private static extern bool GetLastInputInfo(ref GClass7.GStruct0 gstruct0_0);

        // Token: 0x060005BC RID: 1468 RVA: 0x00145990 File Offset: 0x00143D90
        public static uint smethod_0()
        {
            GClass7.GStruct0 gstruct = new GClass7.GStruct0(); // Инициализация переменной "gstruct"
            gstruct.uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct));
            GClass7.GetLastInputInfo(ref gstruct); // Передача инициализированной переменной "gstruct" в метод
            return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1;
        }


        // Token: 0x02000035 RID: 53
        public struct GStruct0
		{
			// Token: 0x0400031D RID: 797
			public uint uint_0;

			// Token: 0x0400031E RID: 798
			public uint uint_1;
		}
	}
}
