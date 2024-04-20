using System;
using System.Runtime.InteropServices;

namespace cam.DShowNET
{
	// Token: 0x02000021 RID: 33
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56a86893-0ad4-11ce-b03a-0020af0ba770")]
	[ComImport]
	public interface IEnumFilters
	{
		// Token: 0x06000110 RID: 272
		[PreserveSig]
		int Next([In] uint cFilters, ref IBaseFilter x, out uint pcFetched);

		// Token: 0x06000111 RID: 273
		[PreserveSig]
		int Skip([In] int cFilters);

		// Token: 0x06000112 RID: 274
		void Reset();

		// Token: 0x06000113 RID: 275
		void Clone(out IEnumFilters ppEnum);
	}
}
