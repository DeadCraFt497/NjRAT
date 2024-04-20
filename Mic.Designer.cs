namespace NJRAT
{
	// Token: 0x0200001A RID: 26
	
	public partial class Mic : global::System.Windows.Forms.Form
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x0016A1D4 File Offset: 0x001685D4
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

		// Token: 0x06000400 RID: 1024 RVA: 0x0016A224 File Offset: 0x00168624
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.Mic));
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.vmethod_4 = new global::System.Windows.Forms.Timer(this.components);
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ComboBox2 = new global::System.Windows.Forms.ComboBox();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox1.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(2, 3);
			comboBox.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(224, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 0;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(232, 3);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(124, 48);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = true;
			this.vmethod_4.Enabled = true;
			this.vmethod_4.Interval = 50;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(5, 33);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(55, 13);
			label2.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "BufferSize";
			this.ComboBox2.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.ComboBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[] { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" });
			global::System.Windows.Forms.Control comboBox3 = this.ComboBox2;
			point = new global::System.Drawing.Point(86, 30);
			comboBox3.Location = point;
			this.ComboBox2.Name = "ComboBox2";
			global::System.Windows.Forms.Control comboBox4 = this.ComboBox2;
			size = new global::System.Drawing.Size(140, 21);
			comboBox4.Size = size;
			this.ComboBox2.TabIndex = 3;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			point = new global::System.Drawing.Point(0, 55);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(359, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 4;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f); // Указание размера вручную
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(359, 65);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.ComboBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Mic";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mic";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001D7 RID: 471
		private global::System.ComponentModel.IContainer components;
	}
}
