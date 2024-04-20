using System;
using System.Windows.Forms;
using cam.DShowNET;

namespace cam.DirectX.Capture
{
	// Token: 0x02000066 RID: 102
	public class VfwCompressorPropertyPage : PropertyPage
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00006334 File Offset: 0x00004534
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00006380 File Offset: 0x00004580
		public override byte[] State
		{
			get
			{
				byte[] array = null;
				int num = 0;
				int num2 = this.vfwCompressDialogs.GetState(null, ref num);
				if (num2 == 0 && num > 0)
				{
					array = new byte[checked(num - 1 + 1)];
					num2 = this.vfwCompressDialogs.GetState(array, ref num);
					if (num2 != 0)
					{
						array = null;
					}
				}
				return array;
			}
			set
			{
				int num = this.vfwCompressDialogs.SetState(value, value.Length);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000063A0 File Offset: 0x000045A0
		public VfwCompressorPropertyPage(string name__1, IAMVfwCompressDialogs compressDialogs)
		{
			this.vfwCompressDialogs = null;
			this.Name = name__1;
			this.SupportsPersisting = true;
			this.vfwCompressDialogs = compressDialogs;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000063C4 File Offset: 0x000045C4
		public override void Show(Control owner)
		{
			this.vfwCompressDialogs.ShowDialog(VfwCompressDialogs.QueryConfig, owner.Handle);
		}

		// Token: 0x04000179 RID: 377
		protected IAMVfwCompressDialogs vfwCompressDialogs;
	}
}
