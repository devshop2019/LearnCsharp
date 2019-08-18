namespace WebBrowser_ArduinoBlockly
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
            this.btn_openFileHTML = new System.Windows.Forms.Button();
            this.KxnWeb1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btn_openFileHTML
            // 
            this.btn_openFileHTML.Location = new System.Drawing.Point(254, 12);
            this.btn_openFileHTML.Name = "btn_openFileHTML";
            this.btn_openFileHTML.Size = new System.Drawing.Size(75, 23);
            this.btn_openFileHTML.TabIndex = 0;
            this.btn_openFileHTML.Text = "Open HTML";
            this.btn_openFileHTML.UseVisualStyleBackColor = true;
            this.btn_openFileHTML.Click += new System.EventHandler(this.btn_openFileHTML_Click);
            // 
            // KxnWeb1
            // 
            this.KxnWeb1.Location = new System.Drawing.Point(12, 41);
            this.KxnWeb1.MinimumSize = new System.Drawing.Size(20, 20);
            this.KxnWeb1.Name = "KxnWeb1";
            this.KxnWeb1.Size = new System.Drawing.Size(939, 344);
            this.KxnWeb1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 397);
            this.Controls.Add(this.KxnWeb1);
            this.Controls.Add(this.btn_openFileHTML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_openFileHTML;
        private System.Windows.Forms.WebBrowser KxnWeb1;
    }
}

