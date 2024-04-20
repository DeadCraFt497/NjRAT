namespace NJRAT
{
	// Token: 0x02000014 RID: 20
	
	public partial class FURL : global::System.Windows.Forms.Form
	{
		// Token: 0x060002DB RID: 731 RVA: 0x00160154 File Offset: 0x0015E554
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

		// Token: 0x060002DC RID: 732 RVA: 0x001601A4 File Offset: 0x0015E5A4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.FURL));
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label = this.Label2;
			global::System.Drawing.Point point = new global::System.Drawing.Point(11, 9);
			label.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label2 = this.Label2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(30, 13);
			label2.Size = size;
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Link";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label3 = this.Label1;
			point = new global::System.Drawing.Point(10, 47);
			label3.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(46, 13);
			label4.Size = size;
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Run As";
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox2;
			point = new global::System.Drawing.Point(13, 63);
			textBox.Location = point;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox2 = this.TextBox2;
			size = new global::System.Drawing.Size(140, 20);
			textBox2.Size = size;
			this.TextBox2.TabIndex = 9;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox3 = this.TextBox1;
			point = new global::System.Drawing.Point(13, 24);
			textBox3.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox4 = this.TextBox1;
			size = new global::System.Drawing.Size(321, 20);
			textBox4.Size = size;
			this.TextBox1.TabIndex = 8;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button = this.Button2;
			point = new global::System.Drawing.Point(252, 61);
			button.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button2 = this.Button2;
			size = new global::System.Drawing.Size(82, 23);
			button2.Size = size;
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button3 = this.Button1;
			point = new global::System.Drawing.Point(164, 61);
			button3.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button4 = this.Button1;
			size = new global::System.Drawing.Size(82, 23);
			button4.Size = size;
			this.Button1.TabIndex = 6;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(345, 100);
			this.ClientSize = size;
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "FURL";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FURL";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000143 RID: 323
		private global::System.ComponentModel.IContainer components;
	}
}
