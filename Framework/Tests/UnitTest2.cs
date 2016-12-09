using System;
using NUnit.Framework;
using Framework.Steps;
using Framework.Core.Driver;
using Framework;
using System.Threading;
using System.IO;


namespace Tests
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestFixture]
    public class UnitTest2
    {
        User user1;
        User user2;
        User user3;
        Authorisation autorisation;
        SendingMessages sendingMess;
        Exit exit;
        PuttingMessageToSpam spamMessage;
        SettingSettings settings;

        [SetUp]
        public void Init()
        {
            user1 = new User(Data.FirstUserLogin, Data.FirstUserPassword);
            user2 = new User(Data.SecondUserLogin, Data.SecondUserPassword);
            user3 = new User(Data.ThirdUserLogin, Data.ThirdUserPassword);
            autorisation = new Authorisation();
            sendingMess = new SendingMessages();
            exit = new Exit();
            spamMessage = new PuttingMessageToSpam();
            settings = new SettingSettings();

        }

        [TearDown]
        public void Cleanup()
        {
            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            // sett.OpenSettings();
            settings.OpenLinkSettings();
            settings.ChooseForwardPage();

            settings.ClearSettings();
            Thread.Sleep(1000);
            WebDriver.CloseWebDriver();

        }


        [Test]
        public void TestSetSettings()
        {
            string path = TestContext.CurrentContext.TestDirectory;
            autorisation.SetLogin(user2.Login);
            autorisation.SetPassword(user2.Password);
            // sett.OpenSettings();
            settings.OpenLinkSettings();
            settings.ChooseForwardPage();
            settings.AddForwardAddress(user3.Login);
            //Thread.Sleep(1000);
            exit.LogOut();
            exit.ChangeAccount();
            exit.AddAccount();

            autorisation.SetLogin(user3.Login);
            autorisation.SetPassword(user3.Password);

            sendingMess.OpenMessage();
            sendingMess.ConfirmRequest();

            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);

            autorisation.SetPassword(user2.Password);

            //sett.OpenSettings();

            settings.OpenLinkSettings();

            settings.ChooseForwardPage();




            settings.SetFilters(user1.Login);
            settings.ForwardAcopyOfIncomeMail();

            //Thread.Sleep(1000);
            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user1.Login);
            autorisation.SetPassword(user1.Password);
            sendingMess.CreateMessage(user2.Login, Data.FirstMessage);
            sendingMess.SendMessage();
            sendingMess.AttachDocument(path + Data.FileName, user2.Login, Data.FirstMessage);
            Thread.Sleep(2000);
            sendingMess.SendMessage();
            //Thread.Sleep(1000);
            exit.LogOut();
            //ex.ChangeAccount();
            exit.AddAccount();

            autorisation.SetLogin(user2.Login);

            autorisation.SetPassword(user2.Password);
            Assert.IsTrue(spamMessage.IsUnimportant());
            Assert.IsTrue(spamMessage.IsImportant());

            exit.LogOut();
            exit.AddAccount();

            autorisation.SetLogin(user3.Login);
            autorisation.SetPassword(user3.Password);

            sendingMess.OpenMessage();
            string message = sendingMess.GetMessageText();
            Assert.AreEqual(Data.FirstMessage, message);
            

           

        }
    }
}
