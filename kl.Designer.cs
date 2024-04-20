namespace NJRAT
{
	// Token: 0x02000015 RID: 21
	
	public partial class kl : global::System.Windows.Forms.Form
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00160AA8 File Offset: 0x0015EEA8
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

		// Token: 0x060002F2 RID: 754 RVA: 0x00160AF8 File Offset: 0x0015EEF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.kl));
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TFind = new global::System.Windows.Forms.ToolStripTextBox();
			this.ToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 322);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(641, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 0;
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.ToolStripMenuItem1, this.ToolStripMenuItem2, this.TFind, this.ToolStripMenuItem3 });
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			point = new global::System.Drawing.Point(0, 0);
			menuStrip.Location = point;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new global::System.Drawing.Size(641, 27);
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
			this.TFind.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.TFind.Name = "TFind";
			global::System.Windows.Forms.ToolStripControlHost tfind = this.TFind;
			size = new global::System.Drawing.Size(100, 23);
			tfind.Size = size;
			this.TFind.Text = "..";
			this.ToolStripMenuItem3.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem3 = this.ToolStripMenuItem3;
			size = new global::System.Drawing.Size(100, 23);
			toolStripMenuItem3.Size = size;
			this.ToolStripMenuItem3.Text = "Fix [BackSpace]";
			this.T1.BackColor = global::System.Drawing.Color.MintCream;
			this.T1.ContextMenuStrip = this.ContextMenuStrip1;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control t = this.T1;
			point = new global::System.Drawing.Point(0, 27);
			t.Location = point;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(641, 295);
			t2.Size = size;
			this.T1.TabIndex = 2;
			this.T1.Text = "";
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.CopyToolStripMenuItem, this.SelectAllToolStripMenuItem });
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.ShowImageMargin = false;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(98, 48);
			contextMenuStrip.Size = size;
			this.CopyToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.CopyToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new global::System.Drawing.Size(97, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copy";
			this.SelectAllToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.SelectAllToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem selectAllToolStripMenuItem = this.SelectAllToolStripMenuItem;
			size = new global::System.Drawing.Size(97, 22);
			selectAllToolStripMenuItem.Size = size;
			this.SelectAllToolStripMenuItem.Text = "Select All";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(641, 332);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "kl";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "kl";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400014C RID: 332
		private global::System.ComponentModel.IContainer components;
	}
}
