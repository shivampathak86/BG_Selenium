using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Selenium.Framework
{
    public class LoginPage
    {
        
 
        [FindsBy(How = How.Id, Using = "txtEmail")]
        public  IWebElement Username;


        [FindsBy(How = How.Id, Using = "txtPassword")]
        public  IWebElement Password;

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        public  IWebElement SubmitBtn;

 

        public static LoginPage Goto()
        {
            Driver.DriverInstance.Navigate().GoToUrl("https://sc.bluegreenowner.com/");
           
          
            return new LoginPage();
            

        }

        public LoginPage Login(string username, string password)
        {
            //var UserName = Driver.instance.FindElement(By.Id("txtEmail"));
            //UserName.SendKeys(username);

            //var Pwd = Driver.instance.FindElement(By.Id("txtPassword"));
            //Pwd.SendKeys(password);

            //var btn = Driver.instance.FindElement(By.Id("btnSubmit"));
            //btn.Click();

            
            Username.SendKeys(username);
            Password.SendKeys(password);
            SubmitBtn.Click();
            return this; 


        }

        public bool IsUserLoggedIn
        {
            get
            {

                var myBluegreen = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists(By.LinkText("my bluegreen")));

                CapturingAction.CaptureElement(myBluegreen);

                return myBluegreen.Displayed;

            }
        }

        public  void WithVacationClub()
        {
            var vacClubRadiobtn = new WebDriverWait(Driver.DriverInstance, TimeSpan.FromSeconds(20)).Until(
                ExpectedConditions.ElementIsVisible(By.Id("rdoAccountList_0")));
            

            if (vacClubRadiobtn != null)

            {
                
                if (!(vacClubRadiobtn.Selected))
                {
                   CapturingAction.CaptureElement(vacClubRadiobtn);
                    vacClubRadiobtn.Click();
                }
                
            }
        }
    }
    
    
}
