namespace NJRAT
{
	// Token: 0x0200001D RID: 29
	
	public partial class notf : global::System.Windows.Forms.Form
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0016C164 File Offset: 0x0016A564
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

		// Token: 0x06000439 RID: 1081 RVA: 0x0016C1B4 File Offset: 0x0016A5B4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.p = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			this.SuspendLayout();
			this.p.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.p.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control p = this.p;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			p.Location = point;
			this.p.Name = "p";
			global::System.Windows.Forms.Control p2 = this.p;
			global::System.Drawing.Size size = new global::System.Drawing.Size(259, 108);
			p2.Size = size;
			this.p.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.p.TabIndex = 0;
			this.p.TabStop = false;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(259, 108);
			this.ClientSize = size;
			this.Controls.Add(this.p);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "notf";
			this.Opacity = 0.9;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.TransparencyKey = global::System.Drawing.Color.Transparent;
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x040001F3 RID: 499
		private global::System.ComponentModel.IContainer components;
	}
}
