namespace NJRAT
{
	// Token: 0x02000022 RID: 34
	
	public partial class port : global::System.Windows.Forms.Form
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x0016FA9C File Offset: 0x0016DE9C
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

		// Token: 0x060004AC RID: 1196 RVA: 0x0016FAEC File Offset: 0x0016DEEC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(61, 6);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(118, 25);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "5552";
			this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(8, 37);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(171, 33);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(6, 7);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(51, 19);
			label2.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Port :";
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(8, 76);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(171, 33);
			button4.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Exit";
			this.Button2.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(191, 116);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.TextBox1);
			this.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "port";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "njRAT";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000228 RID: 552
		private global::System.ComponentModel.IContainer components;
	}
}
