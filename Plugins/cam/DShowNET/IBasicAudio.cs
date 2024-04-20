using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000010 RID: 16
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[ComVisible(true)]
	[Guid("56a868b3-0ad4-11ce-b03a-0020af0ba770")]
	[ComImport]
	public interface IBasicAudio
	{
		// Token: 0x060000C5 RID: 197
		[PreserveSig]
		int put_Volume(int lVolume);

		// Token: 0x060000C6 RID: 198
		[PreserveSig]
		int get_Volume(ref int plVolume);

		// Token: 0x060000C7 RID: 199
		[PreserveSig]
		int put_Balance(int lBalance);

		// Token: 0x060000C8 RID: 200
		[PreserveSig]
		int get_Balance(ref int plBalance);
	}
}
