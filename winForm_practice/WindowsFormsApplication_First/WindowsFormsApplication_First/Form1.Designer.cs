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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txb_newFootPrint = new System.Windows.Forms.TextBox();
            this.txb_newDeltaAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_newSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_showCurrentAngle_Feeder1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdio_Feeder_4 = new System.Windows.Forms.RadioButton();
            this.rdio_Feeder_3 = new System.Windows.Forms.RadioButton();
            this.rdio_Feeder_2 = new System.Windows.Forms.RadioButton();
            this.rdio_Feeder_1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_showCurrentAngle_Eagle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_heightPartInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_widthPartInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_longPartInfo = new System.Windows.Forms.TextBox();
            this.cb_miror = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdio_Eagle_4 = new System.Windows.Forms.RadioButton();
            this.rdio_Eagle_3 = new System.Windows.Forms.RadioButton();
            this.rdio_Eagle_2 = new System.Windows.Forms.RadioButton();
            this.rdio_Eagle_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_editDeltaAngleInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_editPartInfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SavePartInfor = new System.Windows.Forms.Button();
            this.cbb_editFootprintInfo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComBobox_partName});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 31);
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
            this.button1.Location = new System.Drawing.Point(84, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 6);
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
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
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
            this.btn_Edit_LK.Location = new System.Drawing.Point(245, 8);
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
            this.cb_Part.Location = new System.Drawing.Point(326, 10);
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
            this.btnUpdatePart.Location = new System.Drawing.Point(168, 6);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePart.TabIndex = 6;
            this.btnUpdatePart.Text = "Update Part";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btn_writeCsvPart
            // 
            this.btn_writeCsvPart.Location = new System.Drawing.Point(87, 6);
            this.btn_writeCsvPart.Name = "btn_writeCsvPart";
            this.btn_writeCsvPart.Size = new System.Drawing.Size(75, 23);
            this.btn_writeCsvPart.TabIndex = 5;
            this.btn_writeCsvPart.Text = "WriteCSV";
            this.btn_writeCsvPart.UseVisualStyleBackColor = true;
            this.btn_writeCsvPart.Click += new System.EventHandler(this.btn_writeCsvPart_Click);
            // 
            // btn_ReadPartCsv
            // 
            this.btn_ReadPartCsv.Location = new System.Drawing.Point(6, 6);
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
            this.dataGridView2.Location = new System.Drawing.Point(6, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(966, 327);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.DataMemberChanged += new System.EventHandler(this.dataGridView2_DataMemberChanged);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserAddedRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(978, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Part infor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txb_newFootPrint);
            this.groupBox4.Controls.Add(this.txb_newDeltaAngle);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btn_newSave);
            this.groupBox4.Location = new System.Drawing.Point(6, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 105);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create new";
            // 
            // txb_newFootPrint
            // 
            this.txb_newFootPrint.Location = new System.Drawing.Point(73, 19);
            this.txb_newFootPrint.Name = "txb_newFootPrint";
            this.txb_newFootPrint.Size = new System.Drawing.Size(121, 20);
            this.txb_newFootPrint.TabIndex = 14;
            // 
            // txb_newDeltaAngle
            // 
            this.txb_newDeltaAngle.Location = new System.Drawing.Point(97, 45);
            this.txb_newDeltaAngle.Name = "txb_newDeltaAngle";
            this.txb_newDeltaAngle.Size = new System.Drawing.Size(97, 20);
            this.txb_newDeltaAngle.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Delta Angle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Foot print";
            // 
            // btn_newSave
            // 
            this.btn_newSave.Location = new System.Drawing.Point(60, 71);
            this.btn_newSave.Name = "btn_newSave";
            this.btn_newSave.Size = new System.Drawing.Size(75, 23);
            this.btn_newSave.TabIndex = 0;
            this.btn_newSave.Text = "Save";
            this.btn_newSave.UseVisualStyleBackColor = true;
            this.btn_newSave.Click += new System.EventHandler(this.btn_newSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txb_showCurrentAngle_Feeder1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(501, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 300);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origin Feeder 1";
            // 
            // txb_showCurrentAngle_Feeder1
            // 
            this.txb_showCurrentAngle_Feeder1.Location = new System.Drawing.Point(102, 266);
            this.txb_showCurrentAngle_Feeder1.Name = "txb_showCurrentAngle_Feeder1";
            this.txb_showCurrentAngle_Feeder1.Size = new System.Drawing.Size(59, 20);
            this.txb_showCurrentAngle_Feeder1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Current Angle";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdio_Feeder_4);
            this.panel2.Controls.Add(this.rdio_Feeder_3);
            this.panel2.Controls.Add(this.rdio_Feeder_2);
            this.panel2.Controls.Add(this.rdio_Feeder_1);
            this.panel2.Location = new System.Drawing.Point(51, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 0;
            // 
            // rdio_Feeder_4
            // 
            this.rdio_Feeder_4.AutoSize = true;
            this.rdio_Feeder_4.Location = new System.Drawing.Point(110, 10);
            this.rdio_Feeder_4.Name = "rdio_Feeder_4";
            this.rdio_Feeder_4.Size = new System.Drawing.Size(14, 13);
            this.rdio_Feeder_4.TabIndex = 4;
            this.rdio_Feeder_4.TabStop = true;
            this.rdio_Feeder_4.UseVisualStyleBackColor = true;
            this.rdio_Feeder_4.Click += new System.EventHandler(this.rdio_Feeder_4_Click);
            // 
            // rdio_Feeder_3
            // 
            this.rdio_Feeder_3.AutoSize = true;
            this.rdio_Feeder_3.Location = new System.Drawing.Point(130, 110);
            this.rdio_Feeder_3.Name = "rdio_Feeder_3";
            this.rdio_Feeder_3.Size = new System.Drawing.Size(14, 13);
            this.rdio_Feeder_3.TabIndex = 3;
            this.rdio_Feeder_3.TabStop = true;
            this.rdio_Feeder_3.UseVisualStyleBackColor = true;
            this.rdio_Feeder_3.Click += new System.EventHandler(this.rdio_Feeder_4_Click);
            // 
            // rdio_Feeder_2
            // 
            this.rdio_Feeder_2.AutoSize = true;
            this.rdio_Feeder_2.Location = new System.Drawing.Point(30, 130);
            this.rdio_Feeder_2.Name = "rdio_Feeder_2";
            this.rdio_Feeder_2.Size = new System.Drawing.Size(14, 13);
            this.rdio_Feeder_2.TabIndex = 2;
            this.rdio_Feeder_2.TabStop = true;
            this.rdio_Feeder_2.UseVisualStyleBackColor = true;
            this.rdio_Feeder_2.Click += new System.EventHandler(this.rdio_Feeder_4_Click);
            // 
            // rdio_Feeder_1
            // 
            this.rdio_Feeder_1.AutoSize = true;
            this.rdio_Feeder_1.Location = new System.Drawing.Point(10, 30);
            this.rdio_Feeder_1.Name = "rdio_Feeder_1";
            this.rdio_Feeder_1.Size = new System.Drawing.Size(14, 13);
            this.rdio_Feeder_1.TabIndex = 1;
            this.rdio_Feeder_1.TabStop = true;
            this.rdio_Feeder_1.UseVisualStyleBackColor = true;
            this.rdio_Feeder_1.Click += new System.EventHandler(this.rdio_Feeder_4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_showCurrentAngle_Eagle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_heightPartInfo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txb_widthPartInfo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_longPartInfo);
            this.groupBox2.Controls.Add(this.cb_miror);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(227, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origin Eagle Cadsoft";
            // 
            // txb_showCurrentAngle_Eagle
            // 
            this.txb_showCurrentAngle_Eagle.Location = new System.Drawing.Point(102, 266);
            this.txb_showCurrentAngle_Eagle.Name = "txb_showCurrentAngle_Eagle";
            this.txb_showCurrentAngle_Eagle.Size = new System.Drawing.Size(59, 20);
            this.txb_showCurrentAngle_Eagle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Current Angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txb_heightPartInfo
            // 
            this.txb_heightPartInfo.Location = new System.Drawing.Point(172, 64);
            this.txb_heightPartInfo.Name = "txb_heightPartInfo";
            this.txb_heightPartInfo.Size = new System.Drawing.Size(59, 20);
            this.txb_heightPartInfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Width";
            // 
            // txb_widthPartInfo
            // 
            this.txb_widthPartInfo.Location = new System.Drawing.Point(92, 64);
            this.txb_widthPartInfo.Name = "txb_widthPartInfo";
            this.txb_widthPartInfo.Size = new System.Drawing.Size(59, 20);
            this.txb_widthPartInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Long";
            // 
            // txb_longPartInfo
            // 
            this.txb_longPartInfo.Location = new System.Drawing.Point(14, 64);
            this.txb_longPartInfo.Name = "txb_longPartInfo";
            this.txb_longPartInfo.Size = new System.Drawing.Size(59, 20);
            this.txb_longPartInfo.TabIndex = 3;
            // 
            // cb_miror
            // 
            this.cb_miror.AutoSize = true;
            this.cb_miror.Location = new System.Drawing.Point(6, 18);
            this.cb_miror.Name = "cb_miror";
            this.cb_miror.Size = new System.Drawing.Size(71, 17);
            this.cb_miror.TabIndex = 2;
            this.cb_miror.Text = "Has Miror";
            this.cb_miror.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdio_Eagle_4);
            this.panel1.Controls.Add(this.rdio_Eagle_3);
            this.panel1.Controls.Add(this.rdio_Eagle_2);
            this.panel1.Controls.Add(this.rdio_Eagle_1);
            this.panel1.Location = new System.Drawing.Point(51, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 0;
            // 
            // rdio_Eagle_4
            // 
            this.rdio_Eagle_4.AutoSize = true;
            this.rdio_Eagle_4.Location = new System.Drawing.Point(110, 10);
            this.rdio_Eagle_4.Name = "rdio_Eagle_4";
            this.rdio_Eagle_4.Size = new System.Drawing.Size(14, 13);
            this.rdio_Eagle_4.TabIndex = 4;
            this.rdio_Eagle_4.TabStop = true;
            this.rdio_Eagle_4.UseVisualStyleBackColor = true;
            this.rdio_Eagle_4.Click += new System.EventHandler(this.rdio_Eagle_4_Click);
            // 
            // rdio_Eagle_3
            // 
            this.rdio_Eagle_3.AutoSize = true;
            this.rdio_Eagle_3.Location = new System.Drawing.Point(130, 110);
            this.rdio_Eagle_3.Name = "rdio_Eagle_3";
            this.rdio_Eagle_3.Size = new System.Drawing.Size(14, 13);
            this.rdio_Eagle_3.TabIndex = 3;
            this.rdio_Eagle_3.TabStop = true;
            this.rdio_Eagle_3.UseVisualStyleBackColor = true;
            this.rdio_Eagle_3.Click += new System.EventHandler(this.rdio_Eagle_4_Click);
            // 
            // rdio_Eagle_2
            // 
            this.rdio_Eagle_2.AutoSize = true;
            this.rdio_Eagle_2.Location = new System.Drawing.Point(30, 130);
            this.rdio_Eagle_2.Name = "rdio_Eagle_2";
            this.rdio_Eagle_2.Size = new System.Drawing.Size(14, 13);
            this.rdio_Eagle_2.TabIndex = 2;
            this.rdio_Eagle_2.TabStop = true;
            this.rdio_Eagle_2.UseVisualStyleBackColor = true;
            this.rdio_Eagle_2.Click += new System.EventHandler(this.rdio_Eagle_4_Click);
            // 
            // rdio_Eagle_1
            // 
            this.rdio_Eagle_1.AutoSize = true;
            this.rdio_Eagle_1.Location = new System.Drawing.Point(10, 30);
            this.rdio_Eagle_1.Name = "rdio_Eagle_1";
            this.rdio_Eagle_1.Size = new System.Drawing.Size(14, 13);
            this.rdio_Eagle_1.TabIndex = 1;
            this.rdio_Eagle_1.TabStop = true;
            this.rdio_Eagle_1.UseVisualStyleBackColor = true;
            this.rdio_Eagle_1.Click += new System.EventHandler(this.rdio_Eagle_4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_editDeltaAngleInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_editPartInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_SavePartInfor);
            this.groupBox1.Controls.Add(this.cbb_editFootprintInfo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // txb_editDeltaAngleInfo
            // 
            this.txb_editDeltaAngleInfo.Location = new System.Drawing.Point(97, 75);
            this.txb_editDeltaAngleInfo.Name = "txb_editDeltaAngleInfo";
            this.txb_editDeltaAngleInfo.Size = new System.Drawing.Size(97, 20);
            this.txb_editDeltaAngleInfo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Delta Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Part";
            // 
            // cbb_editPartInfo
            // 
            this.cbb_editPartInfo.FormattingEnabled = true;
            this.cbb_editPartInfo.Location = new System.Drawing.Point(73, 46);
            this.cbb_editPartInfo.Name = "cbb_editPartInfo";
            this.cbb_editPartInfo.Size = new System.Drawing.Size(121, 21);
            this.cbb_editPartInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Foot print";
            // 
            // btn_SavePartInfor
            // 
            this.btn_SavePartInfor.Location = new System.Drawing.Point(60, 115);
            this.btn_SavePartInfor.Name = "btn_SavePartInfor";
            this.btn_SavePartInfor.Size = new System.Drawing.Size(75, 23);
            this.btn_SavePartInfor.TabIndex = 0;
            this.btn_SavePartInfor.Text = "Save";
            this.btn_SavePartInfor.UseVisualStyleBackColor = true;
            // 
            // cbb_editFootprintInfo
            // 
            this.cbb_editFootprintInfo.FormattingEnabled = true;
            this.cbb_editFootprintInfo.Location = new System.Drawing.Point(73, 19);
            this.cbb_editFootprintInfo.Name = "cbb_editFootprintInfo";
            this.cbb_editFootprintInfo.Size = new System.Drawing.Size(121, 21);
            this.cbb_editFootprintInfo.TabIndex = 1;
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox ComBobox_partName;
        private System.Windows.Forms.ComboBox cb_Part;
        private System.Windows.Forms.Button btn_Edit_LK;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SavePartInfor;
        private System.Windows.Forms.ComboBox cbb_editFootprintInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdio_Eagle_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_editPartInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_miror;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_heightPartInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_widthPartInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_longPartInfo;
        private System.Windows.Forms.RadioButton rdio_Eagle_4;
        private System.Windows.Forms.RadioButton rdio_Eagle_3;
        private System.Windows.Forms.RadioButton rdio_Eagle_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txb_showCurrentAngle_Feeder1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdio_Feeder_4;
        private System.Windows.Forms.RadioButton rdio_Feeder_3;
        private System.Windows.Forms.RadioButton rdio_Feeder_2;
        private System.Windows.Forms.RadioButton rdio_Feeder_1;
        private System.Windows.Forms.TextBox txb_showCurrentAngle_Eagle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_editDeltaAngleInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_newFootPrint;
        private System.Windows.Forms.TextBox txb_newDeltaAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_newSave;
    }
}

