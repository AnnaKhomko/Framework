using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using Framework.Elements;
using OpenQA.Selenium;
using Framework.Core.Element;
using Framework.Core.Driver;

namespace Framework.Pages
{
    public class LoginPage : Page
    {
        //public string Uri { get; }
        public Button BtNext
        {
            get
            {
                return new Button("//*[@id=\"next\"]", "BtNext");
            }
        }

        public Button BtLogIn
        {
            get
            {
                return new Button("//*[@id=\"signIn\"]", "BtSignIn");
            }
        }

        public Input InpLogin
        {
            get
            {
                return new Input("//*[@id=\"Email\"]" , "InpLogin");
            }
        }

        public Input InpPassword
        {
            get
            {
                return new Input("//*[@id=\"Passwd\"]", "InpPassword");
            }
        }

        public Link LChangeAccounr
        {
            get
            {
                return new Link("//a[contains(text(),'Sign in with a different account')]", "LChangeAccount");
            }
        }

        public LoginPage(string Uri)
        {
            WebDriver.OpenWebDriver();
            WebDriver.GetDriver().Navigate().GoToUrl(Uri);


            
        }

    }
}
