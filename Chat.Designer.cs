namespace NJRAT
{
	// Token: 0x0200000E RID: 14
	
	public partial class Chat : global::System.Windows.Forms.Form
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0014FF58 File Offset: 0x0014E358
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

		// Token: 0x06000116 RID: 278 RVA: 0x0014FFA8 File Offset: 0x0014E3A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.Chat));
			this.Button1 = new global::System.Windows.Forms.Button();
			this.T2 = new global::System.Windows.Forms.TextBox();
			this.vmethod_8 = new global::System.Windows.Forms.Timer(this.components);
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(400, 125);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(75, 23);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Send";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Visible = false;
			this.T2.BackColor = global::System.Drawing.Color.Black;
			this.T2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.T2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control t = this.T2;
			point = new global::System.Drawing.Point(0, 177);
			t.Location = point;
			this.T2.Name = "T2";
			global::System.Windows.Forms.Control t2 = this.T2;
			size = new global::System.Drawing.Size(417, 20);
			t2.Size = size;
			this.T2.TabIndex = 0;
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.T1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control t3 = this.T1;
			point = new global::System.Drawing.Point(0, 0);
			t3.Location = point;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t4 = this.T1;
			size = new global::System.Drawing.Size(417, 177);
			t4.Size = size;
			this.T1.TabIndex = 23;
			this.T1.Text = "";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(417, 197);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.T2);
			this.Controls.Add(this.Button1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Chat";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chat";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000083 RID: 131
		private global::System.ComponentModel.IContainer components;
	}
}
