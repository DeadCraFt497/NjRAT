namespace NJRAT
{
	// Token: 0x02000020 RID: 32
	
	public partial class pas : global::System.Windows.Forms.Form
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x0016D0CC File Offset: 0x0016B4CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0016D11C File Offset: 0x0016B51C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TFind = new global::System.Windows.Forms.ToolStripTextBox();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 395);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(347, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 0;
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.ToolStripMenuItem1, this.ToolStripMenuItem2, this.TFind });
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			point = new global::System.Drawing.Point(0, 0);
			menuStrip.Location = point;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new global::System.Drawing.Size(347, 27);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = 1;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.BackColor = global::System.Drawing.Color.Black;
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(58, 23);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Refresh";
			this.ToolStripMenuItem2.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem2 = this.ToolStripMenuItem2;
			size = new global::System.Drawing.Size(42, 23);
			toolStripMenuItem2.Size = size;
			this.ToolStripMenuItem2.Text = "Find";
			this.TFind.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TFind.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.TFind.Name = "TFind";
			global::System.Windows.Forms.ToolStripControlHost tfind = this.TFind;
			size = new global::System.Drawing.Size(100, 23);
			tfind.Size = size;
			this.TFind.Text = "..";
			this.T1.BackColor = global::System.Drawing.Color.MintCream;
			this.T1.ContextMenuStrip = this.ContextMenuStrip1;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control t = this.T1;
			point = new global::System.Drawing.Point(0, 27);
			t.Location = point;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(347, 368);
			t2.Size = size;
			this.T1.TabIndex = 2;
			this.T1.Text = "";
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.CopyToolStripMenuItem, this.SelectAllToolStripMenuItem, this.SaveAsToolStripMenuItem });
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.ShowImageMargin = false;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(128, 92);
			contextMenuStrip.Size = size;
			this.CopyToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.CopyToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new global::System.Drawing.Size(127, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copy";
			this.SelectAllToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.SelectAllToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem selectAllToolStripMenuItem = this.SelectAllToolStripMenuItem;
			size = new global::System.Drawing.Size(127, 22);
			selectAllToolStripMenuItem.Size = size;
			this.SelectAllToolStripMenuItem.Text = "Select All";
			this.SaveAsToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.SaveAsToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem saveAsToolStripMenuItem = this.SaveAsToolStripMenuItem;
			size = new global::System.Drawing.Size(127, 22);
			saveAsToolStripMenuItem.Size = size;
			this.SaveAsToolStripMenuItem.Text = "Save As";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(347, 405);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.MenuStrip1);
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "pas";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kl";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000203 RID: 515
		private global::System.ComponentModel.IContainer components;
	}
}
