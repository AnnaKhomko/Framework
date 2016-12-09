using Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class InboxMessages
    {
        public CheckBox ChbCheckMessage
        {
            get
            {
                return new CheckBox("//div[2]/div/table/tbody/tr/td[2]/div/div", "CheckMessage");
            }
        }
        public Button BtReportSpam
        {
            get
            {
                return new Button("//div[@aria-label='Report spam']", "ReportSpam");
            }
        }
    }
}
