using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x0200003A RID: 58
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C6E13380-30AC-11d0-A18C-00A0C9118956")]
	[ComVisible(true)]
	[ComImport]
	public interface IAMCrossbar
	{
		// Token: 0x06000181 RID: 385
		[PreserveSig]
		int get_PinCounts(out int OutputPinCount, out int InputPinCount);

		// Token: 0x06000182 RID: 386
		[PreserveSig]
		int CanRoute([In] int OutputPinIndex, [In] int InputPinIndex);

		// Token: 0x06000183 RID: 387
		[PreserveSig]
		int Route([In] int OutputPinIndex, [In] int InputPinIndex);

		// Token: 0x06000184 RID: 388
		[PreserveSig]
		int get_IsRoutedTo([In] int OutputPinIndex, out int InputPinIndex);

		// Token: 0x06000185 RID: 389
		[PreserveSig]
		int get_CrossbarPinInfo([MarshalAs(UnmanagedType.Bool)] [In] bool IsInputPin, [In] int PinIndex, out int PinIndexRelated, out PhysicalConnectorType PhysicalType);
	}
}
