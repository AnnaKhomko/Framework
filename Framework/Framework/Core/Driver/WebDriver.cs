using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Framework.Core.Driver
{
    public class WebDriver
    {
        private static IWebDriver driverInstance = null;//CreateDriver();

        private WebDriver()
        {
        }

        public static IWebDriver GetDriver ()
        {
                return driverInstance;
        }



        public static void CloseWebDriver()
        {
            driverInstance.Close();

        }

        public static void OpenWebDriver()
        {
            driverInstance = CreateDriver();
        }




        public static IWebDriver CreateDriver()
        {
            string browser = ConfigurationManager.AppSettings["CurrentBrowser"];
            switch (browser)
            {
                case "Firefox":
                    {
                        FirefoxDriverInitializer driver = new FirefoxDriverInitializer();
                        return driver.CreateFirefoxDriver();
                    }
                case "Chrome":
                    {
                        ChromeInitializer driver = new ChromeInitializer();
                        return driver.CreateChromeDriver();
                    }
                case "Opera":
                    {
                        OperaInitializer driver = new OperaInitializer();
                        return driver.CreateOperaDriver();
                    }
                case "IE":
                    {
                        IEInitializer driver = new IEInitializer();
                        return driver.CreateIEDriver();
                    }
                case "Safari":
                    {
                        SafarirInitializer driver = new SafarirInitializer();
                        return driver.CreateSafariDriver();
                    }
                default: return null;
            }
        }

    }
}
