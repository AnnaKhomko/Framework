using Framework.Core.Driver;
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
    public class SettingTheme
    {
        Themes themes = new Themes();
        SettingSettings sett = new SettingSettings();

        public void OpenLinkTheme()
        {
            sett.OpenLinkSettings();
            themes.LThemes.FollowToLink();
            themes.LSetThemes.FollowToLink();

        }

        public void UploadTheme(string path)
        {
            
           // 
            themes.BtMyPhotoes.Click();
            Thread.Sleep(1000);
            WebDriver.GetDriver().SwitchTo().Frame(WebDriver.GetDriver().FindElement(By.XPath("//iframe[@class='KA-JQ']")));
            themes.LUploadPhotos.FollowToLink();
            Thread thread = new Thread(
               () =>
               {
                   Clipboard.SetText(path);
               });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            themes.BtSelectFromComputer.Click();
            SendKeys.SendWait("^(v)");
            Thread.Sleep(2000);
            SendKeys.SendWait("{ENTER}");
            
               
        }

        public bool IsWarningMessage()
        {
            if (themes.TaWarningMessage.IElement.Displayed)
                return true;
            else return false;
        }
    }
}
