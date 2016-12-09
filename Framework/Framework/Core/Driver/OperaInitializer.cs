using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Driver
{
    public class OperaInitializer
    {
        public IWebDriver CreateOperaDriver()
        {
            return new OperaDriver();

        }
    }
}
