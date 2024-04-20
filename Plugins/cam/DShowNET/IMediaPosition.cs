using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200000F RID: 15
	[Guid("56a868b2-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComImport]
	public interface IMediaPosition
	{
		// Token: 0x060000BA RID: 186
		[PreserveSig]
		int get_Duration(ref double pLength);

		// Token: 0x060000BB RID: 187
		[PreserveSig]
		int put_CurrentPosition(double llTime);

		// Token: 0x060000BC RID: 188
		[PreserveSig]
		int get_CurrentPosition(ref double pllTime);

		// Token: 0x060000BD RID: 189
		[PreserveSig]
		int get_StopTime(ref double pllTime);

		// Token: 0x060000BE RID: 190
		[PreserveSig]
		int put_StopTime(double llTime);

		// Token: 0x060000BF RID: 191
		[PreserveSig]
		int get_PrerollTime(ref double pllTime);

		// Token: 0x060000C0 RID: 192
		[PreserveSig]
		int put_PrerollTime(double llTime);

		// Token: 0x060000C1 RID: 193
		[PreserveSig]
		int put_Rate(double dRate);

		// Token: 0x060000C2 RID: 194
		[PreserveSig]
		int get_Rate(ref double pdRate);

		// Token: 0x060000C3 RID: 195
		[PreserveSig]
		int CanSeekForward(ref int pCanSeekForward);

		// Token: 0x060000C4 RID: 196
		[PreserveSig]
		int CanSeekBackward(ref int pCanSeekBackward);
	}
}
