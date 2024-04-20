namespace NJRAT
{
	// Token: 0x02000027 RID: 39
	
	public partial class up : global::System.Windows.Forms.Form
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x001750D4 File Offset: 0x001734D4
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

		// Token: 0x0600054B RID: 1355 RVA: 0x00175124 File Offset: 0x00173524
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("File");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("Size");
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("Speed");
			global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("Uploaded");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NJRAT.up));
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.vmethod_4 = new global::System.Windows.Forms.Timer(this.components);
			this.Lv1 = new global::NJRAT.GClass9();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			global::System.Drawing.Point point = new global::System.Drawing.Point(0, 73);
			progressBar.Location = point;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(581, 23);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 0;
			this.Button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.LimeGreen;
			global::System.Windows.Forms.Control button = this.Button1;
			point = new global::System.Drawing.Point(506, 0);
			button.Location = point;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 73);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Satrt";
			this.Button1.UseVisualStyleBackColor = true;
			this.vmethod_4.Interval = 1000;
			this.Lv1.BackColor = global::System.Drawing.Color.Black;
			this.Lv1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
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
			size = new global::System.Drawing.Size(581, 73);
			lv2.Size = size;
			this.Lv1.TabIndex = 1;
			this.Lv1.UseCompatibleStateImageBehavior = false;
			this.Lv1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Width = 96;
			this.ColumnHeader2.Width = 485;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(581, 96);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Lv1);
			this.Controls.Add(this.ProgressBar1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "up";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "up";
			this.ResumeLayout(false);
		}

		// Token: 0x0400027A RID: 634
		private global::System.ComponentModel.IContainer components;
	}
}
