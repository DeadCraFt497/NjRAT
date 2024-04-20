namespace NJRAT
{
	// Token: 0x02000010 RID: 16
	
	public partial class DW : global::System.Windows.Forms.Form
	{
		// Token: 0x06000153 RID: 339 RVA: 0x0015204C File Offset: 0x0015044C
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

		// Token: 0x06000154 RID: 340 RVA: 0x0015209C File Offset: 0x0015049C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("File");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("Size");
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("Speed");
			global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("Downloaded");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.DW));
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Lv1 = new global::NJRAT.GClass9();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			this.ProgressBar1.BackColor = global::System.Drawing.Color.Black;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 83);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(546, 23);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(469, 0);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(77, 83);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Stop";
			this.Button1.UseVisualStyleBackColor = false;
			this.Timer1.Interval = 1000;
			this.Lv1.BackColor = global::System.Drawing.Color.Black;
			this.Lv1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2 });
			this.Lv1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv1.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.Lv1.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.Lv1.FullRowSelect = true;
			this.Lv1.GridLines = true;
			this.Lv1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.Lv1.Items.AddRange(new global::System.Windows.Forms.ListViewItem[] { listViewItem, listViewItem2, listViewItem3, listViewItem4 });
			global::System.Windows.Forms.Control lv = this.Lv1;
			point = new global::System.Drawing.Point(0, 0);
			lv.Location = point;
			this.Lv1.Name = "Lv1";
			this.Lv1.OwnerDraw = true;
			global::System.Windows.Forms.Control lv2 = this.Lv1;
			size = new global::System.Drawing.Size(546, 83);
			lv2.Size = size;
			this.Lv1.TabIndex = 1;
			this.Lv1.UseCompatibleStateImageBehavior = false;
			this.Lv1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Width = 96;
			this.ColumnHeader2.Width = 446;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(546, 106);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Lv1);
			this.Controls.Add(this.ProgressBar1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "DW";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DW";
			this.ResumeLayout(false);
		}

		// Token: 0x040000A0 RID: 160
		private global::System.ComponentModel.IContainer components;
	}
}
