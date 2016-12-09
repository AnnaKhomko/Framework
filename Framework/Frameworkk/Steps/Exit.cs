using Framework.Core.Driver;
using Framework.Elements;
using Framework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Steps
{
    public class Exit
    {
        MailPage mp = new MailPage();

        public void LogOut()
        {
            Thread.Sleep(1000);

            mp.LAccount.FollowToLink();
            mp.BtSignOut.Click();


        }

        public void ChangeAccount()
        {
            mp.LChangeAccount.FollowToLink();
           

        }

        public void AddAccount()
        {
           
            mp.LAddAccount.FollowToLink();
        }

    }
}
