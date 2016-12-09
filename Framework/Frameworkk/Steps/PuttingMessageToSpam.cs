using Framework.Elements;
using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Steps
{
    public class PuttingMessageToSpam
    {
        MailPage mp = new MailPage();
        InboxMessages im = new InboxMessages();

        public void PutIntoSpam()
        {
      
            im.ChbCheckMessage.Select();
            im.BtReportSpam.Click();

        }

        public void OpenSpam()
        {
           
            mp.LMore.FollowToLink();
            mp.LSpam.FollowToLink();

        }

        public bool IsImportant()
        {
            mp.LMore.FollowToLink();
            mp.LTrash.FollowToLink();
            if (mp.LImportant.IElement.Displayed)
                return true;
            else return false;
        }

        public bool IsUnimportant()
        {
            if (mp.LUnImportant.IElement.Displayed)
                return true;
            else return false;
        }

        public void DeletefromSpam()
        {
            mp.LMore.FollowToLink();
            mp.LSpam.FollowToLink();
            mp.ChbSpamCheckbox.Select();
            mp.BtNotSpam.Click();
            mp.LInbox.FollowToLink();
        }
    }
}
