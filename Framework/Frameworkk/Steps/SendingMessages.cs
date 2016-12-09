using Framework.Core.Driver;
using Framework.Elements;
using Framework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework.Steps
{
    public class SendingMessages
    {
        MailPage mp = new MailPage();
        MessageBoxPage mbp = new MessageBoxPage();
        Settings sett = new Settings();

        public void CreateMessage(string receiver, string text)
        {
            
            mp.BtCompose.Click();
            mbp.TaReceiver.SetText(receiver);
            mbp.TaMessage.SetText(text);
            //mbp.BtSend.Click();

        }

        public void SendMessage()
        {
            mbp.BtSend.Click();
        }

        public void OpenMessage()
        {
            mp.LMessage.FollowToLink();


        }

        public string GetMessageText()
        {

            string message = mp.TaMessageText.GetText();

            return message;
        }

        public void ConfirmRequest()
        {

           
            sett.LconReq.FollowToLink();
            WebDriver.GetDriver().SwitchTo()
                .Window(WebDriver.GetDriver().WindowHandles.Last());
            
            sett.BtConfirm.Click();
            WebDriver.GetDriver().SwitchTo()
                .Window(WebDriver.GetDriver().WindowHandles.First());
        }

        public void AttachDocument(string path, string receiver, string text)
        {
            mp.BtCompose.Click();
            mbp.TaReceiver.SetText(receiver);
            mbp.TaMessage.SetText(text);
            Thread thread = new Thread(
                () =>
                {
                    Clipboard.SetText(path);
                });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            mbp.BtAttach.Click();
            SendKeys.SendWait("^(v)");
            Thread.Sleep(2000);
            SendKeys.SendWait("{ENTER}");
            //Thread.Sleep(1000);
            //mbp.BtSend.Click();
        }

        public bool IsDisplayedAlert()
        {
            //WebDriver.GetDriver().SwitchTo().Alert();
            if (mbp.TaWarningMessage.IElement.Displayed)
                return true;

            else return false;
            
        }

        public void CloseAlert()
        {
            mbp.BtCloseAlert.Click();
        }

        public void SendMessageWithEmoticons(string receiver)
        {
            mp.BtCompose.Click();
            mbp.TaReceiver.SetText(receiver);
            mbp.BtEmoticons.Click();
            mbp.BtAllEmoticons.Click();
            Thread.Sleep(1000);
            mbp.BtFirsEmodi.Click();
            mbp.BtSecondEmodi.Click();
        }

        public bool IsEmodiDisplayed()
        {
            if (mp.BtFirstEmodi.IElement.Displayed && mp.BtSecondEmodi.IElement.Displayed)
                return true;
            else return false;
        }

    }
}
