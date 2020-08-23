using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    //Text vorlesen
     public class SpeakText
    {
        private WebBrowser _web;
        public WebBrowser Web 
        { 
            get { return _web; }
            set { _web=value; } 
        }

        //Constructor
        public SpeakText(WebBrowser wb)
        {
            this.Web = wb;
        }
        private void SetText(string text) 
        {
            HtmlElement ht = Web.Document.GetElementById("text");
            ht.SetAttribute("value", text);
        }
        private void Speak()
        {
            HtmlElement html = Web.Document.GetElementById("playbutton");
            html.InvokeMember("click");
        }
        public void Speak(string data)
        {
            SetText(data);
            Speak();

        }
    }
}
