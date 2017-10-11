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
        [TestMethod]

        public void Can_User_Book_PointsType_Reservation()
        {
            LoginPage.Goto();
            Pages.Loginpage.WithVacationClub("");
            Pages.Bookreservation.SelectPointype().SelectDestination().EnterDates().ClickOnSearch();

        }




    }
}
