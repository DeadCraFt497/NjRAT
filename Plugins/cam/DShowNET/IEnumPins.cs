using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000022 RID: 34
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a86892-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	[ComImport]
	public interface IEnumPins
	{
		// Token: 0x06000114 RID: 276
		[PreserveSig]
		int Next([In] int cPins, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] IPin[] ppPins, out int pcFetched);

		// Token: 0x06000115 RID: 277
		[PreserveSig]
		int Skip([In] int cPins);

		// Token: 0x06000116 RID: 278
		void Reset();

		// Token: 0x06000117 RID: 279
		void Clone(out IEnumPins ppEnum);
	}
}
