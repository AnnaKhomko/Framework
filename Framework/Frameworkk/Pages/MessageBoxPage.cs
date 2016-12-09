using Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class MessageBoxPage
    {
        public TextArea TaReceiver
        {
            get
            {
                return new TextArea("//textarea[@name='to']", "TaReceiver");
            }
        }
        public TextArea TaMessage
        {
            get
            {
                return new TextArea("//tbody/tr/td[2]/div[2]/div", "TaMessageText");
            }
        }
        public Button BtSend
        {
            get
            {
                return new Button("//div[text()='Send']", "BtSend");
            }
        }

        public Button BtAttach
        {
            get
            {
                return new Button("//td[4]/div/div/div/div", "BtAttach");
            }
        }

        public TextArea TaWarningMessage
        {
            get
            {
                return new TextArea("//div[@class='bab']", "TaWarningMessage");
            }
        }

        public Button BtCloseAlert
        {
            get
            {
                return new Button("//span[@aria-label='Close']", "BtCloseAlert");
            }
        }

        public Button BtEmoticons
        {
            get
            {
                return new Button("//div[@class='QT aaA aMZ']", "BtEmoticons");
            }
        }

        public Button BtFirsEmodi
        {
            get
            {
                return new Button("//button[@string='1f60e']", "BtFirstEmodi");
            }
        }

        public Button BtSecondEmodi
        {
            get
            {
                return new Button("//button[@string='1f60d']", "BtSecondEmodi");
            }
        }

        public Button BtAllEmoticons
        {
            get
            {
                return new Button("//button[@title='Show face emoticons']", "BtAllEmoticons");
            }
        }

        public Link LSignature
        {
            get
            {
                return new Link("//a[contains(@href, 'mailto:second.user.example@gmail.com')]", "LSignature");
            }
        }
    }
}
