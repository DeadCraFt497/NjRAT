namespace NJRAT
{
	// Token: 0x0200000F RID: 15
	
	public partial class Dos : global::System.Windows.Forms.Form
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00150B34 File Offset: 0x0014EF34
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

		// Token: 0x0600012A RID: 298 RVA: 0x00150B84 File Offset: 0x0014EF84
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.Dos));
			this.Button1 = new global::System.Windows.Forms.Button();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.ClearLogsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Logs = new global::NJRAT.LV();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.TextBox3 = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.ContextMenuStrip1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Button1.Enabled = false;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(110, 234);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(416, 25);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Start Flood";
			this.Button1.UseVisualStyleBackColor = true;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			point = new global::System.Drawing.Point(111, 27);
			textBox.Location = point;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(195, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 1;
			this.TextBox1.Text = "127.0.0.1";
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			point = new global::System.Drawing.Point(375, 27);
			textBox3.Location = point;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(65, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 2;
			this.TextBox2.Text = "80";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(107, 10);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(48, 14);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Target :";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
			point = new global::System.Drawing.Point(372, 10);
			label3.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(36, 14);
			label4.Size = size;
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Port :";
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2.Font = new global::System.Drawing.Font("Arial", 7f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control button3 = this.Button2;
			point = new global::System.Drawing.Point(312, 27);
			button3.Location = point;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(57, 20);
			button4.Size = size;
			this.Button2.TabIndex = 5;
			this.Button2.Text = "Lock On";
			this.Button2.UseVisualStyleBackColor = true;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.ClearLogsToolStripMenuItem });
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.ShowImageMargin = false;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(79, 26);
			contextMenuStrip.Size = size;
			this.ClearLogsToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.ClearLogsToolStripMenuItem.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.ClearLogsToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.ClearLogsToolStripMenuItem.Name = "ClearLogsToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem clearLogsToolStripMenuItem = this.ClearLogsToolStripMenuItem;
			size = new global::System.Drawing.Size(78, 22);
			clearLogsToolStripMenuItem.Size = size;
			this.ClearLogsToolStripMenuItem.Text = "Clear";
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.Logs);
			global::System.Windows.Forms.Control panel = this.Panel1;
			point = new global::System.Drawing.Point(111, 102);
			panel.Location = point;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			size = new global::System.Drawing.Size(415, 126);
			panel2.Size = size;
			this.Panel1.TabIndex = 7;
			this.Logs.BackColor = global::System.Drawing.Color.Black;
			this.Logs.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1 });
			this.Logs.ContextMenuStrip = this.ContextMenuStrip1;
			this.Logs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Logs.Font = new global::System.Drawing.Font("Arial", 7f, global::System.Drawing.FontStyle.Bold);
			this.Logs.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.Logs.FullRowSelect = true;
			this.Logs.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			global::System.Windows.Forms.Control logs = this.Logs;
			point = new global::System.Drawing.Point(0, 0);
			logs.Location = point;
			this.Logs.Name = "Logs";
			global::System.Windows.Forms.Control logs2 = this.Logs;
			size = new global::System.Drawing.Size(415, 126);
			logs2.Size = size;
			this.Logs.TabIndex = 6;
			this.Logs.UseCompatibleStateImageBehavior = false;
			this.Logs.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Width = 300;
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label3;
			point = new global::System.Drawing.Point(108, 85);
			label5.Location = point;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(41, 14);
			label6.Size = size;
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Logs :";
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] { "Full!!!", "VHigh", "High", "Medium", "Slow", "VSlow" });
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			point = new global::System.Drawing.Point(446, 26);
			comboBox.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new global::System.Drawing.Size(80, 22);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 9;
			this.ComboBox1.Text = "Medium";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			point = new global::System.Drawing.Point(-4, -2);
			pictureBox.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(109, 282);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 19;
			this.PictureBox1.TabStop = false;
			this.TextBox3.BackColor = global::System.Drawing.Color.Black;
			this.TextBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox3.Font = new global::System.Drawing.Font("Arial", 15f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox3.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control textBox5 = this.TextBox3;
			point = new global::System.Drawing.Point(111, 53);
			textBox5.Location = point;
			this.TextBox3.Multiline = true;
			this.TextBox3.Name = "TextBox3";
			global::System.Windows.Forms.Control textBox6 = this.TextBox3;
			size = new global::System.Drawing.Size(415, 29);
			textBox6.Size = size;
			this.TextBox3.TabIndex = 20;
			this.TextBox3.Text = "NONE!";
			this.TextBox3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label4;
			point = new global::System.Drawing.Point(443, 10);
			label7.Location = point;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(39, 14);
			label8.Size = size;
			this.Label4.TabIndex = 21;
			this.Label4.Text = "Preq :";
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(7f, 14f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(536, 267);
			this.ClientSize = size;
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			size = new global::System.Drawing.Size(552, 306);
			this.MaximumSize = size;
			size = new global::System.Drawing.Size(552, 306);
			this.MinimumSize = size;
			this.Name = "Dos";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400008C RID: 140
		private global::System.ComponentModel.IContainer components;
	}
}
