using Framework.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class Themes
    {
       // public string uri = "https://mail.google.com/mail/#inbox";

        public Button BtMyPhotoes
        {
            get
            {
                return new Button("//div[text()='My Photos']", "BtMyPhotoes");
            }
        }

        public Link LThemes
        {
            get
            {
                return new Link("//a[text()='Themes']", "LThemes");
            }
        }

        public Link LSetThemes
        {
            get
            {
                return new Link("//a[text()='Set Theme.']", "LSetThemes");
            }
        }

        public Link LUploadPhotos
        {
            get
            {
                return new Link("//div[text()='Upload a photo']", "LUploadPhotos");
            }
        }

        public Button BtSelectFromComputer
        {
            get
            {
                return new Button("//div[text()='Select a photo from your computer']", "BtSelectFromComputer");
            }
        }

        public TextArea TaWarningMessage
        {
            get
            {
                return new TextArea("//div[text()='Selected file [Matrix.txt] is not supported for upload.']", "TaWarningMessage");
            }
        }


    }
}
