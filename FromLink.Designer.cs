namespace NJRAT
{
	// Token: 0x02000012 RID: 18
	
	public partial class FromLink : global::System.Windows.Forms.Form
	{
		// Token: 0x060001EE RID: 494 RVA: 0x001592A0 File Offset: 0x001576A0
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

		// Token: 0x060001EF RID: 495 RVA: 0x001592F0 File Offset: 0x001576F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.FromLink));
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(165, 61);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(82, 23);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(253, 61);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(82, 23);
			button4.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Cancel";
			this.Button2.UseVisualStyleBackColor = true;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(14, 24);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(321, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 2;
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			point = new global::System.Drawing.Point(14, 63);
			textBox3.Location = point;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(140, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 3;
			this.TextBox2.Text = "File.txt";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(11, 47);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(52, 13);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Save As";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label3 = this.Label2;
			point = new global::System.Drawing.Point(12, 9);
			label3.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(30, 13);
			label4.Size = size;
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Link";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(350, 102);
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
			this.Name = "FromLink";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FromLink";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000E4 RID: 228
		private global::System.ComponentModel.IContainer components;
	}
}
