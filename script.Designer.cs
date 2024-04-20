namespace NJRAT
{
	// Token: 0x02000025 RID: 37
	
	public partial class script : global::System.Windows.Forms.Form
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x00172D1C File Offset: 0x0017111C
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

		// Token: 0x06000506 RID: 1286 RVA: 0x00172D6C File Offset: 0x0017116C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.script));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.ComboBox1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 273);
			panel.Location = point;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(514, 23);
			panel2.Size = size;
			this.Panel1.TabIndex = 0;
			this.Button1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(0, 0);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(441, 21);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Execute";
			this.Button1.UseVisualStyleBackColor = false;
			this.ComboBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] { "vbs", "bat", "cmd", "txt", "html", "hta" });
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			point = new global::System.Drawing.Point(447, 0);
			comboBox.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new global::System.Drawing.Size(67, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 0;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(0, 0);
			textBox.Location = point;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(514, 273);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 1;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			size = new global::System.Drawing.Size(514, 296);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Panel1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "script";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "script";
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000257 RID: 599
		private global::System.ComponentModel.IContainer components;
	}
}
