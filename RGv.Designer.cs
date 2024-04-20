namespace NJRAT
{
	// Token: 0x02000023 RID: 35
	
	public partial class RGv : global::System.Windows.Forms.Form
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00170360 File Offset: 0x0016E760
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

		// Token: 0x060004C0 RID: 1216 RVA: 0x001703B0 File Offset: 0x0016E7B0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.RGv));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox3 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(4, 3);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(35, 13);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Name";
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label3 = this.Label2;
			point = new global::System.Drawing.Point(257, 3);
			label3.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(31, 13);
			label4.Size = size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Type";
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label5 = this.Label3;
			point = new global::System.Drawing.Point(5, 41);
			label5.Location = point;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(34, 13);
			label6.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Value";
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(7, 18);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(246, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 3;
			this.TextBox3.BackColor = global::System.Drawing.Color.Black;
			this.TextBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox3 = this.TextBox3;
			point = new global::System.Drawing.Point(7, 57);
			textBox3.Location = point;
			this.TextBox3.Multiline = true;
			this.TextBox3.Name = "TextBox3";
			global::System.Windows.Forms.Control textBox4 = this.TextBox3;
			size = new global::System.Drawing.Size(472, 88);
			textBox4.Size = size;
			this.TextBox3.TabIndex = 4;
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(7, 146);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(472, 32);
			button2.Size = size;
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = false;
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] { "Binary", "DWord", "ExpandString", "MultiString", "QWord", "String" });
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			point = new global::System.Drawing.Point(259, 17);
			comboBox.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new global::System.Drawing.Size(220, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 6;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(486, 187);
			this.ClientSize = size;
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.ForeColor = global::System.Drawing.Color.White;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "RGv";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RGv";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400022F RID: 559
		private global::System.ComponentModel.IContainer components;
	}
}
