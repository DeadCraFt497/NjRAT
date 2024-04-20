namespace NJRAT
{
	// Token: 0x02000024 RID: 36
	
	public partial class sc : global::System.Windows.Forms.Form
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00170DEC File Offset: 0x0016F1EC
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

		// Token: 0x060004D4 RID: 1236 RVA: 0x00170E3C File Offset: 0x0016F23C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.sc));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.vmethod_16 = new global::System.Windows.Forms.Timer(this.components);
			this.vmethod_12 = new global::System.Windows.Forms.Timer(this.components);
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.p = new global::System.Windows.Forms.PictureBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.ComboBox1);
			this.Panel1.Controls.Add(this.CheckBox1);
			this.Panel1.Controls.Add(this.CheckBox2);
			this.Panel1.Controls.Add(this.CheckBox3);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 0);
			panel.Location = point;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(424, 27);
			panel2.Size = size;
			this.Panel1.TabIndex = 0;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(2, 1);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 22);
			button2.Size = size;
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(82, 5);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(30, 14);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Size";
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[]
			{
				"%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55",
				"%50"
			});
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			point = new global::System.Drawing.Point(116, 2);
			comboBox.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new global::System.Drawing.Size(78, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 3;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			point = new global::System.Drawing.Point(197, 2);
			checkBox.Location = point;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new global::System.Drawing.Size(55, 17);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "Mouse";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control checkBox3 = this.CheckBox2;
			point = new global::System.Drawing.Point(255, 2);
			checkBox3.Location = point;
			this.CheckBox2.Name = "CheckBox2";
			global::System.Windows.Forms.Control checkBox4 = this.CheckBox2;
			size = new global::System.Drawing.Size(68, 17);
			checkBox4.Size = size;
			this.CheckBox2.TabIndex = 1;
			this.CheckBox2.Text = "Keyboard";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control checkBox5 = this.CheckBox3;
			point = new global::System.Drawing.Point(329, 2);
			checkBox5.Location = point;
			this.CheckBox3.Name = "CheckBox3";
			global::System.Windows.Forms.Control checkBox6 = this.CheckBox3;
			size = new global::System.Drawing.Size(70, 17);
			checkBox6.Size = size;
			this.CheckBox3.TabIndex = 0;
			this.CheckBox3.Text = "AutoSave";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.vmethod_16.Enabled = true;
			this.vmethod_16.Interval = 10;
			this.vmethod_12.Enabled = true;
			this.vmethod_12.Interval = 1000;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			point = new global::System.Drawing.Point(0, 246);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(424, 9);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 1;
			this.p.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control p = this.p;
			point = new global::System.Drawing.Point(0, 27);
			p.Location = point;
			this.p.Name = "p";
			global::System.Windows.Forms.Control p2 = this.p;
			size = new global::System.Drawing.Size(424, 228);
			p2.Size = size;
			this.p.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.p.TabIndex = 2;
			this.p.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.Button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(209, 27);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(10, 12);
			button4.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.UseVisualStyleBackColor = false;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(424, 255);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.p);
			this.Controls.Add(this.Panel1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "sc";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "sc";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x0400023A RID: 570
		private global::System.ComponentModel.IContainer components;
	}
}
