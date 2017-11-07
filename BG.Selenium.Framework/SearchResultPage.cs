using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BG.Selenium.Framework
{
    public class SearchResultPage
    {
        [FindsBy(How = How.CssSelector, Using = "table.table-collapse:nth-child(2)")]
        public IWebElement ResortDataTable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='js-my-bluegreen']/a/span[2]")]
        public IWebElement TotalAvailablePoints { get; set; }

        [FindsBy(How = How.LinkText, Using = "book now")]
        public IWebElement BookNowBtn { get; set; }


        public static IWebElement ErrorSevenNightStay
        {

            get
            {
                IWebElement errorMsgDiv = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(7)).Until(
                    ExpectedConditions.ElementIsVisible(By.ClassName("alert alert-info js-updateSearchQuery")));
                return errorMsgDiv;
            }
        }

        public bool WaitForResultToLoad()
        {
            var resultPageLoaded =
                new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='site-content']/div/div/div[2]")));
            return resultPageLoaded.Displayed;
        }



        public SearchResultPage CheckAvailablePoints()

        {
            
             
            IList<IWebElement> resortDataRows = ResortDataTable.FindElements(By.TagName("tr"));

            foreach (IWebElement rows in resortDataRows )
            {
                //string xpath = ".//*[@id='site-content']/div/div/div[2]/div[6]/div[6]/table/tbody/tr[" + rows + "]/a";
                IList<IWebElement> resortDataColumn = rows.FindElements(By.TagName("td"));
                foreach (IWebElement columns in resortDataColumn)
                {

                    if (columns.Text.ToLower().Contains("points"))
                    {

                        var resortInnerHtml = columns.FindElement(By.TagName("a"));
                       
                        string[] resortPoints = resortInnerHtml.Text.Split('\r');
                        
                        
                        //string resortPoints = columns.Text;
                        int points = Int32.Parse(resortPoints[0].Replace(",",""));
                        string[] totalAvailablePointsInnerHtml = TotalAvailablePoints.Text.Split(' ');

                        long availablePoints = long.Parse(totalAvailablePointsInnerHtml[0].Replace(",",""));

                        if (points<availablePoints)
                        {
                            foreach (IWebElement booknowbtn in resortDataColumn)
                            {
                                if (booknowbtn.Text.ToLower().Contains("book now"))
                                {
                                    var b = booknowbtn.FindElement(By.TagName("a"));
                                    b.Click();
                                    break;
                                }
                            }

                        }
                        
                    }
                }
            }
            return this;
        }

        public bool UserReachedToConfirmResvPage()
        {
            var pageurl = Driver.DriverInstance.FindElement(By.Id("form-confirm-reservation-submit"));
            return pageurl.Displayed;

        }
    }
}

    