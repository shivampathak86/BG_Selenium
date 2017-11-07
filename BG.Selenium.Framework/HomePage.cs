using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace BG.Selenium.Framework
{
    public  class HomePage
    {
        public HomePage()
        {
        }

        [FindsBy(How = How.Id, Using ="searchOptions_searchParameters_ReservationType")]
        public IWebElement PoinTypeRadioButton;

        [FindsBy(How=How.Id, Using ="Destination")]
        public  IWebElement selectedDestination { get; set; }

        [FindsBy(How =How.Id, Using="CheckInDate")]
        public IWebElement checkInDate { get; set; }

        [FindsBy(How = How.Id, Using ="CheckOutDate")]
        public IWebElement checkOutDate { get; set; }

        [FindsBy(How = How.Name, Using = "btnSubmit")]
        public IWebElement SearchInventoryBtn { get; set; }



        public  HomePage SelectPointype()
        {
            if (PoinTypeRadioButton != null)
            {
                var pointRadiobtn = PoinTypeRadioButton;
                CapturingAction.CaptureElement(PoinTypeRadioButton);

                if (!(pointRadiobtn.Selected))
                {
              
                    pointRadiobtn.Click();
                }
            }
            return this;
        }

        public HomePage SelectDestination()
        {
            var selectdestination = new SelectElement(selectedDestination);
            selectdestination.SelectByText("Peoria");
            CapturingAction.CaptureElement(selectedDestination);

            return this;
        }
        // Checkin date
        public HomePage CheckinDate(String checkindate)
        {
            SelectDate(checkInDate,checkindate);
            return this;
        }

        // Checkout date
        public HomePage CheckOutDate(string checkoutdate)
        {
            SelectDate(checkOutDate,checkoutdate);
            return this;
        }

        //selecting dates generic method
        protected void SelectDate( IWebElement DateElement, string date)
        {

            var CheckInDate = DateElement;//By.Id("CheckInDate"));
            if (CheckInDate.Displayed)
            {
                CheckInDate.Click();
                IWebElement GetCalendarPicker =
                    new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(5)).Until(
                        ExpectedConditions.ElementIsVisible(By.ClassName("ui-datepicker-calendar")));


                IList<IWebElement> GetCalenderRows = GetCalendarPicker.FindElements(By.TagName("tr"));

                if (GetCalenderRows == null) throw new ArgumentNullException(nameof(GetCalenderRows));

                else if (GetCalenderRows != null)
                {
                    int DatePicketRownumber = GetCalenderRows.Count;
                    foreach (IWebElement CalenderRows in GetCalenderRows)

                    {
                        IList<IWebElement> GetCalenderColumn = CalenderRows.FindElements(By.TagName("td"));
                        if (GetCalenderColumn != null)
                        {
                            foreach (IWebElement CalendarColumns in GetCalenderColumn)
                            {
                                if(CalendarColumns.Text.ToUpper().Equals(date))
                                    CalendarColumns.Click();
                            }
                        }

                    }
                }
            }
            
        }


        public SearchResultPage ClickOnSearchButton()
        {
            SearchInventoryBtn.Click();
            return  new SearchResultPage();
        }

    }
}