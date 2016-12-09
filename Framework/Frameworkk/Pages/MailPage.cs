using Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class MailPage
    {
        public Button BtCompose
        {
            get
            {
                return new Button("//div[text()='COMPOSE']", "BtCompose");
            }
        }
        public Link LMore
        {
            get
            {
                return new Link("//span[text()='More']", "LMore");
            }
        }
        
        public Link LSpam
        {
            get
            {
                return new Link("//a[contains(text(), 'Spam')]", "LSpam");
            }
        }
        public Link LAccount
        {
            get
            {
                return new Link("//div/a/span", "LAccount");
            }
        }
        public Button BtSignOut
        {
            get
            {
                return new Button("//a[text()='Sign out']", "BtSignOut");
            }
        }
        public Link LMessage
        {
            get
            {
                return new Link("//td[6]/div/div/div", "LMessage");
            }
        }
        public TextArea TaMessageText
        {
            get
            {
                return new TextArea("//div[2]/div[7]/div/div", "TaMessageText");
            }
        }

        public Link LChangeAccount
        {
            get
            {
                return new Link("//*[@id=\"account-chooser-link\"]", "LChangeAccount");

            }
        } 

        public Link LAddAccount
        {
            get
            {
                return new Link("//a[text()='Add account']", "LAddAccount");
            }
        }

        public Button BtWin
        {
            get
            {
                return new Button("//div[23]", "BtWin");
            }
        }

        public Link LTrash
        {
            get
            {
                return new Link("//a[contains(text(), 'Trash')]", "LTrash");
            }
        }

        public Link LImportant
        {
            get
            {
                return new Link("//div[@aria-label='Important because it matched one of your importance filters.']", "LImportant");
            }
        }
        public Link LUnImportant
        {
            get
            {
                return new Link("//div[@aria-label='Not important']", "LUnImportant");
            }
        }

        public Button BtFirstEmodi
        {
            get
            {
                return new Button("//img[@data-goomoji='1f60e']", "ImgFirstEmodi");
            }
        }

        public Button BtSecondEmodi
        {
            get
            {
                return new Button("//img[@data-goomoji='1f60d']", "ImgSecondEmodi");
            }
        }

        public Link LInbox
        {
            get
            {
                return new Link("//a[contains(text(), 'Inbox')]", "LInbox");
            }
        }

        public Button BtNotSpam
        {
            get
            {
                return new Button("//div[text()='Not spam']", "BtNotSpam");
            }
        }

        public CheckBox ChbSpamCheckbox
        {
            get
            {
                return new CheckBox("//div[4]/div/div/table/tbody/tr/td[2]/div", "ChbSpamMessage");
            }
        }

        public Link LStar
        {
            get
            {
                return new Link("//span[@aria-label='Not starred']", "LStar");
            }
        }

        public Link LStarred
        {
            get
            {
                return new Link("//a[contains(text(),'Starred')]", "LStarred");
            }
        }

        public CheckBox ChbStarred
        {
            get
            {
                return new CheckBox("//div[4]/div/div/table/tbody/tr/td[3]/span", "ChbStarred");
            }
        }

    }
}
