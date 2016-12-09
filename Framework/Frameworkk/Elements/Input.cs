using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Element;
using Framework.Core;

namespace Framework.Elements
{
    public class Input : Element
    {

        public Input(string xPath) : base (xPath)
        {
            
        }

        public Input(string xPath, string name) : base(xPath, name)
        {

        }

        public void SetText(string text)
        {
           
            IElement.Clear();
            Logger.LogToFile($"Input {name} was cleared");
            IElement.SendKeys(text);
            Logger.LogToFile($"Text: '{text}' was setted in input {name}");

        }
    }
}
