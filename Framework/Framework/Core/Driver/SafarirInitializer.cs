using OpenQA.Selenium;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Driver
{
    public class SafarirInitializer
    {
        public IWebDriver CreateSafariDriver()
        {
            return new SafariDriver();
        }
    }
}
