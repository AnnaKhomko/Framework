using Framework.Core;
using Framework.Core.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Elements
{
    public class CheckBox : Element 
    {
        public CheckBox(string xPath) : base (xPath)
        {

        }

        public CheckBox(string xPath, string name) : base(xPath, name)
        {

        }

        public void Select()
        {


            if (!IElement.Selected)
            {
                IElement.Click();
            }

            Logger.LogToFile($"CheckBox {name} was selected!");
        }

        public void Deselect()
        {


            if (IElement.Selected)
            {
                IElement.Click();
            }

            Logger.LogToFile($"CheckBox {name} was deselected!");
        }
    }
}
