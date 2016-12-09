using Framework.Core;
using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class RadioButton : Element
    {
        public RadioButton(string xPath) : base(xPath)
        {
        }

        public RadioButton(string xPath, string name) : base(xPath, name)
        {

        }

        public void Select()
        {
            if (!IElement.Selected)
            {
                IElement.Click();
            }

            Logger.LogToFile($"RadioButton {name} was selected!");
        }
    
    }
}
