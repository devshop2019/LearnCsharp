namespace NewBrowser_Test
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Read_WriteValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Read_WriteValue
            // 
            this.btn_Read_WriteValue.Location = new System.Drawing.Point(145, 21);
            this.btn_Read_WriteValue.Name = "btn_Read_WriteValue";
            this.btn_Read_WriteValue.Size = new System.Drawing.Size(75, 23);
            this.btn_Read_WriteValue.TabIndex = 0;
            this.btn_Read_WriteValue.Text = "button1";
            this.btn_Read_WriteValue.UseVisualStyleBackColor = true;
            this.btn_Read_WriteValue.Click += new System.EventHandler(this.btn_Read_WriteValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Read_WriteValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Read_WriteValue;
    }
}

