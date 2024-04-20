namespace ch
{
	
	public partial class C : global::System.Windows.Forms.Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003AF8 File Offset: 0x00001EF8
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

		// Token: 0x06000023 RID: 35 RVA: 0x00003B48 File Offset: 0x00001F48
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ch.C));
			this.T2 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.PictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			this.T2.BackColor = global::System.Drawing.Color.Black;
			this.T2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.T2.ForeColor = global::System.Drawing.Color.Lime;
			global::System.Windows.Forms.Control t = this.T2;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 326);
			t.Location = point;
			this.T2.Name = "T2";
			global::System.Windows.Forms.Control t2 = this.T2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(273, 20);
			t2.Size = size;
			this.T2.TabIndex = 0;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(466, 186);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 12);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			this.PictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox3.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox3;
			point = new global::System.Drawing.Point(3, 3);
			pictureBox.Location = point;
			this.PictureBox3.Name = "PictureBox3";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox3;
			size = new global::System.Drawing.Size(33, 32);
			pictureBox2.Size = size;
			this.PictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox3.TabIndex = 22;
			this.PictureBox3.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.Silver;
			global::System.Windows.Forms.Control label = this.Label2;
			point = new global::System.Drawing.Point(42, 13);
			label.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label2 = this.Label2;
			size = new global::System.Drawing.Size(83, 15);
			label2.Size = size;
			this.Label2.TabIndex = 21;
			this.Label2.Text = "Chatting With";
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.PictureBox3);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.ForeColor = global::System.Drawing.Color.SkyBlue;
			global::System.Windows.Forms.Control panel = this.Panel2;
			point = new global::System.Drawing.Point(0, 0);
			panel.Location = point;
			this.Panel2.Name = "Panel2";
			global::System.Windows.Forms.Control panel2 = this.Panel2;
			size = new global::System.Drawing.Size(273, 38);
			panel2.Size = size;
			this.Panel2.TabIndex = 22;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.Silver;
			global::System.Windows.Forms.Control label3 = this.Label1;
			point = new global::System.Drawing.Point(121, 13);
			label3.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(16, 15);
			label4.Size = size;
			this.Label1.TabIndex = 23;
			this.Label1.Text = "...";
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.T1.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.T1.ForeColor = global::System.Drawing.Color.Lime;
			global::System.Windows.Forms.Control t3 = this.T1;
			point = new global::System.Drawing.Point(0, 38);
			t3.Location = point;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t4 = this.T1;
			size = new global::System.Drawing.Size(273, 288);
			t4.Size = size;
			this.T1.TabIndex = 23;
			this.T1.Text = "";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1;
			size = new global::System.Drawing.Size(273, 346);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.T2);
			this.Name = "C";
			this.Opacity = 0.95;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components;
	}
}
