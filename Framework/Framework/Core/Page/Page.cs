using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public abstract class Page
    {
        public Uri Uri { get; }
        protected string Title;
    }
}
