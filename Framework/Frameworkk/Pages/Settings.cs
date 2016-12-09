using Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class Settings
    {

        public string uri = "https://mail.google.com/mail/#settings/general";


        //public Button BtSettings
        //{
        //    get
        //    {
        //        return new Button("//div[2]/div/div/div/div/div[4]/div[2]/div[2]/div");
        //    }
        //}
        public Link LForwarding
        {
            get
            {
                return new Link("//a[text()='Forwarding and POP/IMAP']", "LForwarding");

            }
        }
        public Button BtAddForwAddress
        {
            get
            {
                return new Button("//input[@value='Add a forwarding address']", "BtAddForwardAddress");
            }
        }
        public Input InpAddress
        {
            get
            {
                return new Input("//*[@class='PN']/input", "InpAddress");
            }
        }
        public Button BtNext
        {
            get
            {
                return new Button("//button[text()='Next']", "BtNext");
            }
        }
        public Button BtProceed
        {
            get
            {
                return new Button("//input[@value='Proceed']", "BtProceed");
            }
        }
        public Button BtOk
        {
            get
            {
                return new Button("//button[@name='ok']", "BtOk");
            }
        }
        public RadioButton RbForwardACopy
        {
            get
            {
                return new RadioButton("//span[contains(.,'Forward a copy of incoming mail to')]/../preceding-sibling::td/input", "RbForwardACopy");
            }
        }
        public Link LFilters
        {
            get
            {
                return new Link("//span[text()='creating a filter!']", "LCreateFilters");
            }
        }
        public Input InpFrom
        {
            get
            {
                return new Input("//span[2]/input", "InpFrom");
            }
        }
        public CheckBox ChbHasAttachment
        {
            get
            {
                return new CheckBox("//div[7]/span/input", "ChbHasAttachment");
            }
        }
        public CheckBox ChbDeleteIt
        {
            get
            {
                return new CheckBox("//div[6]/input", "ChbDeleteIt");
            }
        }
        public Link LFilterWithSearch
        {
            get
            {
                return new Link("//div[text()='Create filter with this search »']", "LFilterWithSearch");
            }
        }
        public CheckBox ChbMarkAsImportant
        {
            get
            {
                return new CheckBox("//div[8]/input", "ChbMarkAsImportant");
            }
        }
        public Button BtCreateFilters
        {
            get
            {
                return new Button("//div[text()='Create filter']", "BtCreateFilters");
            }
        }

        public Button BtConfirm
        {
            get
            {
                return new Button("//input[@value='Confirm']", "BtConfirm");
            }
        }


        public Link LconReq
        {
            get
            {
                return new Link("//a[4]", "LconReq");
            }
        } 

        public Button BtSaveChanges
        {
            get
            {
                return new Button("//button[text()='Save Changes']", "BtSaveChanges");
            }
        }

        public CheckBox ChbSignature
        {
            get
            {
                return new CheckBox("//input[@name='sx_sg']", "ChbSignature");
            }
        }

        public TextArea TaSignature
        {
            get
            {
                return new TextArea("//div[@aria-label='Signature']", "TaSignature");
            }
                }

        public Button BtSelect
        {
            get
            {
                return new Button("//span/select", "BtSelect");
            }
        }

        public Link LRemove
        {
            get
            {
                return new Link("//option[@value='2']", "LRemoveUserFromFilter");
            }
        }

       
        
    }
}
