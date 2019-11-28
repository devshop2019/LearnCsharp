namespace DemoMultiColumnSort
{
	partial class DemoMultiColumnSort
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.PersonGrid = new Mobius.Utility.SortedDataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EnumLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StringLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PersonGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 393);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(635, 22);
			this.statusStrip.TabIndex = 1;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(620, 17);
			this.toolStripStatusLabel.Spring = true;
			this.toolStripStatusLabel.Text = "Not sorted";
			this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PersonGrid
			// 
			this.PersonGrid.AllowUserToAddRows = false;
			this.PersonGrid.AllowUserToOrderColumns = true;
			this.PersonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PersonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Date,
            this.Region,
            this.EnumLevel,
            this.StringLevel});
			this.PersonGrid.Location = new System.Drawing.Point(13, 13);
			this.PersonGrid.MaxSortColumns = 0;
			this.PersonGrid.Name = "PersonGrid";
			this.PersonGrid.RowHeadersVisible = false;
			this.PersonGrid.Size = new System.Drawing.Size(610, 377);
			this.PersonGrid.TabIndex = 0;
			this.PersonGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonGrid_ColumnHeaderMouseClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Width = 40;
			// 
			// FirstName
			// 
			this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			// 
			// LastName
			// 
			this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			// 
			// Date
			// 
			dataGridViewCellStyle1.Format = "d";
			dataGridViewCellStyle1.NullValue = null;
			this.Date.DefaultCellStyle = dataGridViewCellStyle1;
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.Width = 90;
			// 
			// Region
			// 
			this.Region.HeaderText = "Region";
			this.Region.Name = "Region";
			this.Region.Width = 70;
			// 
			// EnumLevel
			// 
			this.EnumLevel.HeaderText = "Level as enum";
			this.EnumLevel.Name = "EnumLevel";
			this.EnumLevel.Width = 80;
			// 
			// StringLevel
			// 
			this.StringLevel.HeaderText = "Level as string";
			this.StringLevel.Name = "StringLevel";
			this.StringLevel.Width = 80;
			// 
			// DemoMultiColumnSort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 415);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.PersonGrid);
			this.Name = "DemoMultiColumnSort";
			this.Text = "DataGridView Multi-column Sort Demo";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PersonGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mobius.Utility.SortedDataGridView PersonGrid;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegionCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn EnumLevel;
		private System.Windows.Forms.DataGridViewTextBoxColumn StringLevel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Region;
	}
}

