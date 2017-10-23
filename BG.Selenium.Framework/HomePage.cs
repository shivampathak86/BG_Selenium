using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public IWebElement PoinTypeRadioButton;

        [FindsBy(How=How.Id, Using ="Destination")]
          
        public  IWebElement selectedDestination { get; set; }




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
    }
}