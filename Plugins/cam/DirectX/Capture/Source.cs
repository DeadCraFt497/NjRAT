using System;

namespace cam.DirectX.Capture
{
	// Token: 0x02000062 RID: 98
	public class Source : IDisposable
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00005DE4 File Offset: 0x00003FE4
		public string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00005E0C File Offset: 0x0000400C
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00005E1C File Offset: 0x0000401C
		public virtual bool Enabled
		{
			get
			{
				bool flag = true;
				return flag;
			}
			set
			{
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00005E20 File Offset: 0x00004020
		~Source()
		{
			this.Dispose();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00005E4C File Offset: 0x0000404C
		public virtual void Dispose()
		{
			this.m_name = null;
		}

		// Token: 0x04000174 RID: 372
		protected string m_name;
	}
}
