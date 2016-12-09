using Framework.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Utils
{
    public class Waiters
    {
        //public IWebElement WaitForElement(int timeout, By by)
        //{
        //    IWait<IWebDriver> wait = new WebDriverWait(WebDriver.GetDriver(), TimeSpan.FromSeconds(timeout));
        //    return wait.Until(ExpectedConditions.ElementIsVisible(by));
        //}
        public IWebElement WaitForElement(int timeout, By by)
        {
            IWait<IWebDriver> wait = new WebDriverWait(WebDriver.GetDriver(), TimeSpan.FromSeconds(timeout));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
