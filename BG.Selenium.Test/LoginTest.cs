using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BG.Selenium.Framework;

namespace BG.Selenium.Test
{
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize();
            
        }


        [TestMethod]
        public void Can_User_login()
        {


           LoginPage.Goto();//Open the Url

            Assert.IsTrue(Pages.Loginpage.Login("775701@bxgcorp.com", "hut44#").IsUserLoggedIn(), "Unable to Login"); // Assert User is logged in
              
            
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.CleanUp();

        }
    }
}
