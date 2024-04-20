using System;
using System.Windows.Forms;

namespace cam.DirectX.Capture
{
	// Token: 0x0200005B RID: 91
	public class PropertyPage : IDisposable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00005904 File Offset: 0x00003B04
		public virtual byte[] State
		{
			get
			{
				byte[] array = new byte[10];
				return array;
			}
			set
			{
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00005908 File Offset: 0x00003B08
		public PropertyPage()
		{
			this.SupportsPersisting = false;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005918 File Offset: 0x00003B18
		public virtual void Show(Control owner)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000591C File Offset: 0x00003B1C
		public void Dispose()
		{
		}

		// Token: 0x04000159 RID: 345
		public string Name;

		// Token: 0x0400015A RID: 346
		public bool SupportsPersisting;
	}
}
