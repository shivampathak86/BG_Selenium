using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BG.Selenium.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BG.Selenium.Test
{
    [TestClass]
    public class BookingReservation
    {
        [ClassInitialize]
        public static void Initialize(TestContext testcontext)
        {
            Driver.Initialize();
            
        }
        
        [TestMethod]
       
        public void Can_User_Reach_To_Search_Result_Page()
        {

            LoginPage.Goto();
            Pages.Loginpage.Login("775699@bxgcorp.com", "hut44#").WithVacationClub(); ;
            
            //Pages.Loginpage.WithVacationClub();// Login with ownerType

            
             /* Select PointType 
             * Select Destination
             * Select Check in Date
             * Select Check Out Date
             */
            Assert.IsTrue(Pages.Bookreservation.SelectPointype().SelectDestination().CheckinDate("2").CheckOutDate("4")
                .ClickOnSearchButton().WaitForResultToLoad(),"Results not displayed, check the Code");

          

            //SearchResultPagesult.CheckAvailablePoints().IfPointsNotEnough().ClickOnBookResort();

        }
        [TestMethod]
        public void Can_User_Select_Resort()
        {


           Assert.IsTrue(Pages.ResultPage.ClickOnBookNowbtn().UserReachedToConfirmResvPage(),"Test Failed");
        }

       
            

        
        [ClassCleanup]
        public static void CleanUp()
        {
            Driver.CleanUp();
        }

    }
}
