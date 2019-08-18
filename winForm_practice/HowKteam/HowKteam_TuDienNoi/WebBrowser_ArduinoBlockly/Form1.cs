using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_ArduinoBlockly
{
    public partial class Form1 : Form
    {
        WebBrowser kxnWeb;

        public WebBrowser KxnWeb
        {
            get
            {
                return kxnWeb;
            }

            set
            {
                kxnWeb = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            //KxnWeb = new WebBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public void SetUpWebView()
        {
            
            //KxnWeb.Width = 2000;
            //KxnWeb.Height = 600;
            //KxnWeb.Visible = true;           //false Ẩn
            KxnWeb1.ScriptErrorsSuppressed = false; //true Ẩn lỗi Java Scrip
            

            string filepath = @"G:\MyCloud\github\devshop2019\LearnCsharp\winForm_practice\HowKteam\HowKteam_TuDienNoi\WebBrowser_ArduinoBlockly\bin\Debug/index1.html";

            KxnWeb1.Navigate(filepath);
            //KxnWeb1.Url = new Uri(filepath);


            //FileStream source = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            //KxnWeb.DocumentStream = source;

            //Uri uri = new Uri(filepath);
            //webBrowser1.Navigate(uri);

            //kxnWeb.Navigate(uri);    /// Chạy link

            //this.Controls.Add(KxnWeb);    // Add vao form
        }

        private void btn_openFileHTML_Click(object sender, EventArgs e)
        {
            SetUpWebView();
        }
    }
}
