using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Element;
using Framework.Core;

namespace Framework.Elements
{
    public class Button : Element
    {
        
        public Button(string xPath) : base(xPath)
        {
            
        }

        public Button(string xPath, string name) : base(xPath, name)
        {

        }

        public void Click()
        {
            
            IElement.Click();
            Logger.LogToFile($"Button {name} was clicked!");
        }
    }
}
