namespace WindowsFormsApplication_First
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ComBobox_partName = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Edit_LK = new System.Windows.Forms.Button();
            this.cb_Part = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.btn_writeCsvPart = new System.Windows.Forms.Button();
            this.btn_ReadPartCsv = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(151, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComBobox_partName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 53);
            // 
            // ComBobox_partName
            // 
            this.ComBobox_partName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComBobox_partName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComBobox_partName.Name = "ComBobox_partName";
            this.ComBobox_partName.Size = new System.Drawing.Size(121, 23);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 402);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Edit_LK);
            this.tabPage1.Controls.Add(this.cb_Part);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import file tọa độ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_LK
            // 
            this.btn_Edit_LK.Location = new System.Drawing.Point(27, 6);
            this.btn_Edit_LK.Name = "btn_Edit_LK";
            this.btn_Edit_LK.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit_LK.TabIndex = 4;
            this.btn_Edit_LK.Text = "Edit LK";
            this.btn_Edit_LK.UseVisualStyleBackColor = true;
            this.btn_Edit_LK.Click += new System.EventHandler(this.btn_Edit_LK_Click);
            // 
            // cb_Part
            // 
            this.cb_Part.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Part.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Part.FormattingEnabled = true;
            this.cb_Part.Location = new System.Drawing.Point(3, 35);
            this.cb_Part.Name = "cb_Part";
            this.cb_Part.Size = new System.Drawing.Size(142, 21);
            this.cb_Part.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdatePart);
            this.tabPage2.Controls.Add(this.btn_writeCsvPart);
            this.tabPage2.Controls.Add(this.btn_ReadPartCsv);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import file Part";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.Location = new System.Drawing.Point(246, 232);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePart.TabIndex = 6;
            this.btnUpdatePart.Text = "Update Part";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btn_writeCsvPart
            // 
            this.btn_writeCsvPart.Location = new System.Drawing.Point(491, 232);
            this.btn_writeCsvPart.Name = "btn_writeCsvPart";
            this.btn_writeCsvPart.Size = new System.Drawing.Size(75, 23);
            this.btn_writeCsvPart.TabIndex = 5;
            this.btn_writeCsvPart.Text = "WriteCSV";
            this.btn_writeCsvPart.UseVisualStyleBackColor = true;
            this.btn_writeCsvPart.Click += new System.EventHandler(this.btn_writeCsvPart_Click);
            // 
            // btn_ReadPartCsv
            // 
            this.btn_ReadPartCsv.Location = new System.Drawing.Point(377, 232);
            this.btn_ReadPartCsv.Name = "btn_ReadPartCsv";
            this.btn_ReadPartCsv.Size = new System.Drawing.Size(75, 23);
            this.btn_ReadPartCsv.TabIndex = 4;
            this.btn_ReadPartCsv.Text = "Read";
            this.btn_ReadPartCsv.UseVisualStyleBackColor = true;
            this.btn_ReadPartCsv.Click += new System.EventHandler(this.btn_ReadPartCsv_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(877, 200);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.DataMemberChanged += new System.EventHandler(this.dataGridView2_DataMemberChanged);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 299);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Export TXT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 426);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentPhoneDataGridViewTextBoxColumn;
        //private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ReadPartCsv;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_writeCsvPart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox ComBobox_partName;
        private System.Windows.Forms.ComboBox cb_Part;
        private System.Windows.Forms.Button btn_Edit_LK;
        private System.Windows.Forms.Button btnUpdatePart;
    }
}

