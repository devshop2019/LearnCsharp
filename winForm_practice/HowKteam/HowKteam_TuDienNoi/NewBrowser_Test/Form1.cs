using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace NewBrowser_Test
{
    public partial class Form1 : Form
    {
        #region add 1
        private ChromiumWebBrowser browser;

        public ChromiumWebBrowser Browser
        {
            get
            {
                return browser;
            }

            set
            {
                browser = value;
            }
        }

        public void InitBrowser()
        {
            // https://www.telerik.com/support/kb/winforms/details/how-to-embed-chrome-browser-in-a-winforms-application
            Cef.Initialize(new CefSettings());

            string filepath = @"G:\MyCloud\github\devshop2019\LearnCsharp\winForm_practice\HowKteam\HowKteam_TuDienNoi\WebBrowser_ArduinoBlockly\bin\Debug/index1.html";
            Browser = new ChromiumWebBrowser(filepath);

            //browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;


            //((ChromiumWebBrowser)Browser).FrameLoadEnd += Browser_FrameLoadEnd;

        }

        async void Browser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            Console.WriteLine("cef-" + e.Url);

            if (e.Frame.IsMain)
            {
                string HTML = await e.Frame.GetSourceAsync();
                Console.WriteLine(HTML);
            }
        }

        #endregion


        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Read_WriteValue_Click(object sender, EventArgs e)
        {
            #region Y tuong 1
            //HtmlElement element = Browser.Document.GetElementById("text");
            //Browser.get
            //element.SetAttribute("value", "data");
            #endregion

            #region Y tuong 2
            //string script = string.Format("document.getElementById('content_arduino').value;");

            //browser.EvaluateScriptAsync(script).ContinueWith(x =>
            //{
            //    var response = x.Result;

            //    if (response.Success && response.Result != null)
            //    {
            //        var startDate = response.Result;
            //        MessageBox.Show(startDate);
            //        //startDate is the value of a HTML element.
            //    }
            //});
            #endregion

            #region Y tuong 3
            //// Step 01: create a simple html page (include jquery so we have access to json object
            //StringBuilder htmlPage = new StringBuilder();
            //htmlPage.AppendLine("");
            //htmlPage.AppendLine("");
            //htmlPage.AppendLine("");
            //htmlPage.AppendLine("");
            //htmlPage.AppendLine("Hello world 2");
            //htmlPage.AppendLine("");

            //// Step 02: Load the Page
            //Browser.LoadHtml(htmlPage.ToString(), "http://customrendering/");

            //// Step 03: Define and Execute some ad-hoc JS that returns an object back to C#
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("function tempFunction() {");
            //sb.AppendLine("     // create a JS object");
            //sb.AppendLine("     var person = {firstName:'John', lastName:'Maclaine', age:23, eyeColor:'blue'};");
            //sb.AppendLine("");
            //sb.AppendLine("     // Important: convert object to string before returning to C#");
            //sb.AppendLine("     return JSON.stringify(person);");
            //sb.AppendLine("}");
            //sb.AppendLine("tempFunction();");

            //var task = Browser.EvaluateScriptAsync(sb.ToString());

            //task.ContinueWith(t =>
            //{
            //    if (!t.IsFaulted)
            //    {
            //        // Step 04: Recieve value from JS
            //        var response = t.Result;

            //        if (response.Success == true)
            //        {
            //            // Use JSON.net to convert to object;
            //            MessageBox.Show(response.Result.ToString());
            //        }
            //    }
            //}, TaskScheduler.FromCurrentSynchronizationContext());

            #endregion

            #region Y tuong 4
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("function tempFunction() {");
            sb.AppendLine("     // create a JS object");
            sb.AppendLine("     var person = document.getElementById(\"content_arduino\").innerHTML;");
            sb.AppendLine("");
            sb.AppendLine("     // Important: convert object to string before returning to C#");
            sb.AppendLine("     return person;");
            sb.AppendLine("}");
            sb.AppendLine("tempFunction();");

            var task = Browser.EvaluateScriptAsync(sb.ToString());

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;

                    if (response.Success == true)
                    {
                        MessageBox.Show(response.Result.ToString());
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());

            #endregion

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
