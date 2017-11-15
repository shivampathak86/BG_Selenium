using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BG.Selenium.Framework;

namespace BG.Selenium.Test
{ 
    [TestClass]
    public class NavigatingTopMenuItems
    {
      [ClassInitialize]

      public static void Initialize(TestContext testcontext)
        {
            Driver.Initialize();
        }

     [ClassCleanup]

     public static void CleanUp()
        {
            Driver.CleanUp();
        }
    [TestMethod]
    public void Can_User_Select_BookkTopNav_Items()
        {
            LoginPage.Goto();

            Pages.Loginpage.Login("775699@bxgcorp.com", "hut44#").WithVacationClub();



            Pages.HomePage.SelectMenuUnderBookTopNav();

        }

    }



    
}
