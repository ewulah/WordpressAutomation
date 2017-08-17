using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTest
{
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void User_Can_Login()
        {
            //var c = new Class1();
            //c.Go();

            LoginPage.GoTo();
            LoginPage.LoginAs("ewulah").WithPassword("2poopies").Login();
            Assert.IsTrue(DasboardPage.IsAt, "Failed to login.");
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
