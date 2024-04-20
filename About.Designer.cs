namespace NJRAT
{
	// Token: 0x0200000B RID: 11
	
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0014B630 File Offset: 0x00149A30
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

		// Token: 0x0600009B RID: 155 RVA: 0x0014B680 File Offset: 0x00149A80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.About));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.RichTextBox1 = new global::System.Windows.Forms.RichTextBox();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			pictureBox.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(168, 158);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.RichTextBox1.BackColor = global::System.Drawing.Color.Black;
			this.RichTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RichTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RichTextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control richTextBox = this.RichTextBox1;
			point = new global::System.Drawing.Point(168, 0);
			richTextBox.Location = point;
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.ReadOnly = true;
			global::System.Windows.Forms.Control richTextBox2 = this.RichTextBox1;
			size = new global::System.Drawing.Size(285, 158);
			richTextBox2.Size = size;
			this.RichTextBox1.TabIndex = 1;
			this.RichTextBox1.Text = "";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			size = new global::System.Drawing.Size(453, 158);
			this.ClientSize = size;
			this.Controls.Add(this.RichTextBox1);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000048 RID: 72
		private global::System.ComponentModel.IContainer components;
	}
}
