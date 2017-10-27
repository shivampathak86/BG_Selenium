using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BG.Selenium.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BG.Selenium.Test
{
    [TestClass]
    public class BookingReservation
    {
        [TestInitialize]
        public void Initialize()
        {
            Driver.Initialize();
        }
        [TestMethod]

        public void Can_User_Book_PointsType_Reservation()
        {

            LoginPage.Goto();
            Pages.Loginpage.Login("775699@bxgcorp.com","hut44#");
            
            Pages.Loginpage.WithVacationClub();// Login with ownerType

            
             /* Select PointType 
             * Select Destination
             * Select Check in Date
             * Select Check Out Date
             */
            Pages.Bookreservation.SelectPointype().SelectDestination().CheckinDate("2").CheckOutDate("4");

        }




    }
}
