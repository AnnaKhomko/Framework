using Framework.Core;
using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class Link : Element
    {
        public Link(string xPath) : base (xPath)
        {

        }

        public Link(string xPath, string name) : base(xPath, name)
        {

        }

        public void FollowToLink()
        {
            IElement.Click();
            Logger.LogToFile($"Link {name} was followed!");
        }
    }
}
