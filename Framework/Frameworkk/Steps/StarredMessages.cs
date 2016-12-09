using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Steps
{
    public class StarredMessages
    {
        MailPage mp = new MailPage();

        public void StarredMessage()
        {
            mp.LStar.FollowToLink();
            mp.LStarred.FollowToLink();

        }

        public bool IsStarred()
        {
            return mp.ChbStarred.IElement.Displayed;
        }
    }
}
