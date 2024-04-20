namespace NJRAT
{
	// Token: 0x02000021 RID: 33
	
	public partial class Pass : global::System.Windows.Forms.Form
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x0016DD00 File Offset: 0x0016C100
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

		// Token: 0x06000472 RID: 1138 RVA: 0x0016DD50 File Offset: 0x0016C150
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.Pass));
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyUseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyPassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopySiteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyALLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InClipboardToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InDiskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FindToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveEmptyPWToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.L1 = new global::NJRAT.GClass9();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.ContextMenuStrip1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ContextMenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.CopyUseToolStripMenuItem, this.CopyPassToolStripMenuItem, this.CopySiteToolStripMenuItem, this.CopyALLToolStripMenuItem, this.SaveAllToolStripMenuItem, this.FindToolStripMenuItem, this.RemoveEmptyPWToolStripMenuItem });
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.ContextMenuStrip1.ShowImageMargin = false;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(151, 180);
			contextMenuStrip.Size = size;
			this.CopyUseToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopyUseToolStripMenuItem.Name = "CopyUseToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyUseToolStripMenuItem = this.CopyUseToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			copyUseToolStripMenuItem.Size = size;
			this.CopyUseToolStripMenuItem.Text = "Copy User";
			this.CopyPassToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopyPassToolStripMenuItem.Name = "CopyPassToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyPassToolStripMenuItem = this.CopyPassToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			copyPassToolStripMenuItem.Size = size;
			this.CopyPassToolStripMenuItem.Text = "Copy Pass";
			this.CopySiteToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopySiteToolStripMenuItem.Name = "CopySiteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copySiteToolStripMenuItem = this.CopySiteToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			copySiteToolStripMenuItem.Size = size;
			this.CopySiteToolStripMenuItem.Text = "Copy Site";
			this.CopyALLToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyALLToolStripMenuItem = this.CopyALLToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			copyALLToolStripMenuItem.Size = size;
			this.CopyALLToolStripMenuItem.Text = "Copy ALL";
			this.SaveAllToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.InClipboardToolStripMenuItem, this.InDiskToolStripMenuItem });
			this.SaveAllToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem saveAllToolStripMenuItem = this.SaveAllToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			saveAllToolStripMenuItem.Size = size;
			this.SaveAllToolStripMenuItem.Text = "Save All";
			this.InClipboardToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.InClipboardToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.InClipboardToolStripMenuItem.Name = "InClipboardToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem inClipboardToolStripMenuItem = this.InClipboardToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			inClipboardToolStripMenuItem.Size = size;
			this.InClipboardToolStripMenuItem.Text = "in Clipboard";
			this.InDiskToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.InDiskToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.InDiskToolStripMenuItem.Name = "InDiskToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem inDiskToolStripMenuItem = this.InDiskToolStripMenuItem;
			size = new global::System.Drawing.Size(139, 22);
			inDiskToolStripMenuItem.Size = size;
			this.InDiskToolStripMenuItem.Text = "in Disk";
			this.FindToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem findToolStripMenuItem = this.FindToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			findToolStripMenuItem.Size = size;
			this.FindToolStripMenuItem.Text = "Find";
			this.RemoveEmptyPWToolStripMenuItem.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.RemoveEmptyPWToolStripMenuItem.Name = "RemoveEmptyPWToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem removeEmptyPWToolStripMenuItem = this.RemoveEmptyPWToolStripMenuItem;
			size = new global::System.Drawing.Size(150, 22);
			removeEmptyPWToolStripMenuItem.Size = size;
			this.RemoveEmptyPWToolStripMenuItem.Text = "Remove Empty PW";
			this.SaveFileDialog1.FileName = "Pass.txt";
			this.SaveFileDialog1.Filter = "Text|.txt";
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "1.bmp");
			this.ImageList1.Images.SetKeyName(1, "2.bmp");
			this.ImageList1.Images.SetKeyName(2, "3.bmp");
			this.ImageList1.Images.SetKeyName(3, "4.bmp");
			this.ImageList1.Images.SetKeyName(4, "5.bmp");
			this.ImageList1.Images.SetKeyName(5, "6.bmp");
			this.ImageList1.Images.SetKeyName(6, "7.bmp");
			this.ImageList1.Images.SetKeyName(7, "8.bmp");
			this.ImageList1.Images.SetKeyName(8, "9.bmp");
			this.ImageList1.Images.SetKeyName(9, "10.bmp");
			this.ImageList1.Images.SetKeyName(10, "11.bmp");
			this.ImageList1.Images.SetKeyName(11, "12.bmp");
			this.ImageList1.Images.SetKeyName(12, "13.bmp");
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.ToolStripMenuItem1 });
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 222);
			menuStrip.Location = point;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new global::System.Drawing.Size(679, 24);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = 1;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(82, 20);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Passwords";
			this.L1.BackColor = global::System.Drawing.Color.Black;
			this.L1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5 });
			this.L1.ContextMenuStrip = this.ContextMenuStrip1;
			this.L1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.L1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.L1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.L1.FullRowSelect = true;
			global::System.Windows.Forms.Control l = this.L1;
			point = new global::System.Drawing.Point(0, 0);
			l.Location = point;
			this.L1.Name = "L1";
			this.L1.OwnerDraw = true;
			global::System.Windows.Forms.Control l2 = this.L1;
			size = new global::System.Drawing.Size(679, 222);
			l2.Size = size;
			this.L1.SmallImageList = this.ImageList1;
			this.L1.TabIndex = 2;
			this.L1.UseCompatibleStateImageBehavior = false;
			this.L1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "UserName";
			this.ColumnHeader1.Width = 115;
			this.ColumnHeader2.Text = "Password";
			this.ColumnHeader2.Width = 93;
			this.ColumnHeader3.Text = "URL";
			this.ColumnHeader3.Width = 93;
			this.ColumnHeader4.Text = "App";
			this.ColumnHeader4.Width = 95;
			this.ColumnHeader5.Text = "User";
			this.ColumnHeader5.Width = 276;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(679, 246);
			this.ClientSize = size;
			this.Controls.Add(this.L1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Pass";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pass";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000211 RID: 529
		private global::System.ComponentModel.IContainer components;
	}
}
