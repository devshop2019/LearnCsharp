namespace cmd_WriteAndRead_app
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
            this.btn_runCMD = new System.Windows.Forms.Button();
            this.btn_cmdRunNgam = new System.Windows.Forms.Button();
            this.btn_readPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_runCMD
            // 
            this.btn_runCMD.Location = new System.Drawing.Point(12, 12);
            this.btn_runCMD.Name = "btn_runCMD";
            this.btn_runCMD.Size = new System.Drawing.Size(108, 23);
            this.btn_runCMD.TabIndex = 0;
            this.btn_runCMD.Text = "Chạy lệnh CMD";
            this.btn_runCMD.UseVisualStyleBackColor = true;
            this.btn_runCMD.Click += new System.EventHandler(this.btn_runCMD_Click);
            // 
            // btn_cmdRunNgam
            // 
            this.btn_cmdRunNgam.Location = new System.Drawing.Point(126, 12);
            this.btn_cmdRunNgam.Name = "btn_cmdRunNgam";
            this.btn_cmdRunNgam.Size = new System.Drawing.Size(108, 23);
            this.btn_cmdRunNgam.TabIndex = 1;
            this.btn_cmdRunNgam.Text = "Chạy lệnh CMD ngầm";
            this.btn_cmdRunNgam.UseVisualStyleBackColor = true;
            this.btn_cmdRunNgam.Click += new System.EventHandler(this.btn_cmdRunNgam_Click);
            // 
            // btn_readPath
            // 
            this.btn_readPath.Location = new System.Drawing.Point(12, 51);
            this.btn_readPath.Name = "btn_readPath";
            this.btn_readPath.Size = new System.Drawing.Size(75, 23);
            this.btn_readPath.TabIndex = 2;
            this.btn_readPath.Text = "Read path";
            this.btn_readPath.UseVisualStyleBackColor = true;
            this.btn_readPath.Click += new System.EventHandler(this.btn_readPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_readPath);
            this.Controls.Add(this.btn_cmdRunNgam);
            this.Controls.Add(this.btn_runCMD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_runCMD;
        private System.Windows.Forms.Button btn_cmdRunNgam;
        private System.Windows.Forms.Button btn_readPath;
    }
}

