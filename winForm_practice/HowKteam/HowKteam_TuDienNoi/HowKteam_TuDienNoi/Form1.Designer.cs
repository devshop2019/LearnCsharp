namespace HowKteam_TuDienNoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Word = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_Meaning = new System.Windows.Forms.TextBox();
            this.txb_explaning = new System.Windows.Forms.TextBox();
            this.btn_Word = new System.Windows.Forms.Button();
            this.btn_Meaning = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Word
            // 
            this.cb_Word.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_Word.FormattingEnabled = true;
            this.cb_Word.Location = new System.Drawing.Point(3, 3);
            this.cb_Word.Name = "cb_Word";
            this.cb_Word.Size = new System.Drawing.Size(138, 332);
            this.cb_Word.TabIndex = 0;
            this.cb_Word.SelectedIndexChanged += new System.EventHandler(this.cb_Word_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Word);
            this.panel1.Controls.Add(this.cb_Word);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 341);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_Meaning);
            this.panel2.Controls.Add(this.txb_explaning);
            this.panel2.Controls.Add(this.txb_Meaning);
            this.panel2.Location = new System.Drawing.Point(192, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 341);
            this.panel2.TabIndex = 2;
            // 
            // txb_Meaning
            // 
            this.txb_Meaning.Location = new System.Drawing.Point(4, 3);
            this.txb_Meaning.Name = "txb_Meaning";
            this.txb_Meaning.Size = new System.Drawing.Size(473, 20);
            this.txb_Meaning.TabIndex = 0;
            // 
            // txb_explaning
            // 
            this.txb_explaning.Location = new System.Drawing.Point(4, 29);
            this.txb_explaning.Multiline = true;
            this.txb_explaning.Name = "txb_explaning";
            this.txb_explaning.Size = new System.Drawing.Size(473, 309);
            this.txb_explaning.TabIndex = 1;
            // 
            // btn_Word
            // 
            this.btn_Word.BackgroundImage = global::HowKteam_TuDienNoi.Properties.Resources.Desert;
            this.btn_Word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Word.Location = new System.Drawing.Point(147, 3);
            this.btn_Word.Name = "btn_Word";
            this.btn_Word.Size = new System.Drawing.Size(23, 23);
            this.btn_Word.TabIndex = 1;
            this.btn_Word.UseVisualStyleBackColor = true;
            // 
            // btn_Meaning
            // 
            this.btn_Meaning.BackgroundImage = global::HowKteam_TuDienNoi.Properties.Resources.Desert;
            this.btn_Meaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Meaning.Location = new System.Drawing.Point(481, 1);
            this.btn_Meaning.Name = "btn_Meaning";
            this.btn_Meaning.Size = new System.Drawing.Size(23, 23);
            this.btn_Meaning.TabIndex = 2;
            this.btn_Meaning.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::HowKteam_TuDienNoi.Properties.Resources.Desert;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(483, 315);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anh-Việt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Word;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Meaning;
        private System.Windows.Forms.TextBox txb_explaning;
        private System.Windows.Forms.TextBox txb_Meaning;
    }
}

