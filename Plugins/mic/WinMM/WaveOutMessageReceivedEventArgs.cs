using System;

namespace WinMM
{
	// Token: 0x0200000B RID: 11
	public sealed class WaveOutMessageReceivedEventArgs : EventArgs
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public WaveOutMessageReceivedEventArgs(WaveOutMessage message)
		{
			this.message = message;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004CB0 File Offset: 0x00002EB0
		public WaveOutMessage Message
		{
			get
			{
				return this.message;
			}
		}

		// Token: 0x0400003B RID: 59
		private WaveOutMessage message;
	}
}
