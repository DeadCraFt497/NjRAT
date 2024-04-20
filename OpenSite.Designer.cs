namespace NJRAT
{
	// Token: 0x0200001F RID: 31
	
	public partial class OpenSite : global::System.Windows.Forms.Form
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x0016CB44 File Offset: 0x0016AF44
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

		// Token: 0x06000448 RID: 1096 RVA: 0x0016CB94 File Offset: 0x0016AF94
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.OpenSite));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(9, 14);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(28, 14);
			label2.Size = size;
			this.Label1.TabIndex = 6;
			this.Label1.Text = "URL";
			this.TextBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(43, 12);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(393, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 5;
			this.TextBox1.Text = "http://www.google.com";
			this.Button1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(442, 8);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(91, 27);
			button2.Size = size;
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Open";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(545, 44);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			size = new global::System.Drawing.Size(561, 83);
			this.MaximumSize = size;
			size = new global::System.Drawing.Size(561, 83);
			this.MinimumSize = size;
			this.Name = "OpenSite";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OpenSite";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001FD RID: 509
		private global::System.ComponentModel.IContainer components;
	}
}
