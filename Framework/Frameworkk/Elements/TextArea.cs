using Framework.Core;
using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class TextArea : Element
    {
        public TextArea(string xPath) : base (xPath)
        {

        }

        public TextArea(string xPath, string name) : base(xPath, name)
        {

        }

        public void SetText(string text)
        {
            IElement.Clear();
            Logger.LogToFile($"TextArea {name} was cleared");
            IElement.SendKeys(text);
            Logger.LogToFile($"Text: '{text}' was setted in TextArea {name}");
        }

        public string GetText()
        {

            return IElement.Text;
        }
    }
}
