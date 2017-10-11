using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BG.Selenium.Framework
{
    public  class HomePage
    {
        public HomePage()
        {
        }

        [FindsBy(How = How.Id, Using ="searchOptions_searchParameters_ReservationType")]
        public static IWebElement PoinTypeRadioButton { get; set; }

        public static HomePage SelectPointype()
        {
            var pointRadiobtn = PoinTypeRadioButton;
            if (!(pointRadiobtn.Selected))
            {
              
                pointRadiobtn.Click();
            }
            return new HomePage();
        }

    }
}