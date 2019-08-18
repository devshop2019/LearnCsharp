using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowKteam_TuDienNoi
{
    public class SpeakText
    {
        private WebBrowser wbWeb;

        public WebBrowser WbWeb
        {
            get
            {
                return wbWeb;
            }

            set
            {
                wbWeb = value;
            }
        }

        public SpeakText(WebBrowser web)
        {
            this.WbWeb = web;
        }

        public void SetText(string data)
        {
            HtmlElement element = WbWeb.Document.GetElementById("text");
            element.SetAttribute("value", data);
        }

        public void Speak()
        {
            HtmlElement element = WbWeb.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }

        public void Spreak(string data)
        {
            SetText(data);
            Speak();
        }
    }
}
