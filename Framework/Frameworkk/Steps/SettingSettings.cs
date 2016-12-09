using Framework.Core.Driver;
using Framework.Elements;
using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Steps
{
    public class SettingSettings
    {
        MailPage mp = new MailPage();
        Settings sett = new Settings();
        MessageBoxPage mbp = new MessageBoxPage();

        //public void OpenSettings()
        //{

           
        //    sett.BtSettings.Click();
        //}

        public void OpenLinkSettings()
        {

            WebDriver.GetDriver().Navigate().GoToUrl(sett.uri);
        }

        public void ChooseForwardPage()
        {

           
            sett.LForwarding.FollowToLink();
        }

        public void AddForwardAddress(string address)
        {
            sett.BtAddForwAddress.Click();
            Thread.Sleep(100);
            sett.InpAddress.SetText(address);
            sett.BtNext.Click();

            WebDriver.GetDriver().SwitchTo()
                .Window(WebDriver.GetDriver().WindowHandles.Last());
            
            sett.BtProceed.Click();

            WebDriver.GetDriver().SwitchTo()
               .Window(WebDriver.GetDriver().WindowHandles.First());
            
            sett.BtOk.Click();
           
        }

        public void ForwardAcopyOfIncomeMail()
        {
            sett.RbForwardACopy.Select();
            sett.BtSaveChanges.Click();
        }

        public void SetFilters(string address)
        {
            sett.LFilters.FollowToLink();
            sett.InpFrom.SetText(address);
            sett.ChbHasAttachment.Select();
            sett.LFilterWithSearch.FollowToLink();
            sett.ChbDeleteIt.Select();
            sett.ChbMarkAsImportant.Select();
            sett.BtCreateFilters.Click();
        }

        public void SetSignature(string signature)
        {
            sett.ChbSignature.Select();
            sett.TaSignature.SetText(signature);
            Thread.Sleep(1000);
            sett.BtSaveChanges.Click();
        }

        public bool IsSignature(string sign)
        {
            mp.BtCompose.Click();
            var ness= mbp.TaMessage.GetText();
            Thread.Sleep(1000);
            return ness.Contains(sign);
            //return mbp.LSignature.IElement.Displayed;
        }

        public void ClearSettings()
        {
            sett.BtSelect.Click();
            sett.LRemove.FollowToLink();
           
            sett.BtOk.Click();
        }
    }
}
