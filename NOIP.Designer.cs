namespace NJRAT
{
	// Token: 0x0200001B RID: 27
	
	public partial class NOIP : global::System.Windows.Forms.Form
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x0016ADC8 File Offset: 0x001691C8
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

		// Token: 0x06000416 RID: 1046 RVA: 0x0016AE18 File Offset: 0x00169218
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.NOIP));
			this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.RichTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.RichTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.TextBox3 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.BackColor = global::System.Drawing.Color.Black;
			this.LinkLabel1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control linkLabel = this.LinkLabel1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(178, 333);
			linkLabel.Location = point;
			this.LinkLabel1.Name = "LinkLabel1";
			global::System.Windows.Forms.Control linkLabel2 = this.LinkLabel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(77, 13);
			linkLabel2.Size = size;
			this.LinkLabel1.TabIndex = 28;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "www.noip.com";
			this.RichTextBox2.BackColor = global::System.Drawing.Color.Black;
			this.RichTextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.RichTextBox2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.RichTextBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control richTextBox = this.RichTextBox2;
			point = new global::System.Drawing.Point(12, 234);
			richTextBox.Location = point;
			this.RichTextBox2.Name = "RichTextBox2";
			global::System.Windows.Forms.Control richTextBox2 = this.RichTextBox2;
			size = new global::System.Drawing.Size(243, 96);
			richTextBox2.Size = size;
			this.RichTextBox2.TabIndex = 27;
			this.RichTextBox2.Text = "";
			this.RichTextBox1.BackColor = global::System.Drawing.Color.Black;
			this.RichTextBox1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control richTextBox3 = this.RichTextBox1;
			point = new global::System.Drawing.Point(374, 294);
			richTextBox3.Location = point;
			this.RichTextBox1.Name = "RichTextBox1";
			global::System.Windows.Forms.Control richTextBox4 = this.RichTextBox1;
			size = new global::System.Drawing.Size(37, 22);
			richTextBox4.Size = size;
			this.RichTextBox1.TabIndex = 25;
			this.RichTextBox1.Text = "";
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial Black", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(12, 192);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(243, 36);
			button2.Size = size;
			this.Button1.TabIndex = 24;
			this.Button1.Text = "Update";
			this.Button1.UseVisualStyleBackColor = false;
			this.TextBox3.BackColor = global::System.Drawing.Color.Black;
			this.TextBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.TextBox3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox3;
			point = new global::System.Drawing.Point(12, 166);
			textBox.Location = point;
			this.TextBox3.Name = "TextBox3";
			global::System.Windows.Forms.Control textBox2 = this.TextBox3;
			size = new global::System.Drawing.Size(243, 20);
			textBox2.Size = size;
			this.TextBox3.TabIndex = 23;
			this.TextBox3.Text = "Host.no-ip.biz";
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.TextBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			point = new global::System.Drawing.Point(12, 140);
			textBox3.Location = point;
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.PasswordChar = '*';
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(243, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 22;
			this.TextBox2.Text = "Password";
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox5 = this.TextBox1;
			point = new global::System.Drawing.Point(12, 114);
			textBox5.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox6 = this.TextBox1;
			size = new global::System.Drawing.Size(243, 20);
			textBox6.Size = size;
			this.TextBox1.TabIndex = 21;
			this.TextBox1.Text = "Email";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			point = new global::System.Drawing.Point(32, 12);
			pictureBox.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(203, 81);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 29;
			this.PictureBox1.TabStop = false;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(265, 354);
			this.ClientSize = size;
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.RichTextBox2);
			this.Controls.Add(this.RichTextBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "NOIP";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "No-Ip";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001E2 RID: 482
		private global::System.ComponentModel.IContainer components;
	}
}
