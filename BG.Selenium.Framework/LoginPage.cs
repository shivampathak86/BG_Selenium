﻿using OpenQA.Selenium;
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
        public static IWebElement Username;


        [FindsBy(How = How.Id, Using = "txtPassword")]
        public static IWebElement Password;

        [FindsBy(How = How.Id, Using = "btnSubmit")]
        public static IWebElement SubmitBtn;

        public static void Goto()
        {
            Driver.instance.Navigate().GoToUrl("https://sc.bluegreenowner.com/");

        }

        public static LoginPage Login(string username, string password)
        {
            var UserName = Driver.instance.FindElement(By.Id("txtEmail"));
            UserName.SendKeys(username);

            var Pwd = Driver.instance.FindElement(By.Id("txtPassword"));
            Pwd.SendKeys(password);

            var btn = Driver.instance.FindElement(By.Id("btnSubmit"));
            btn.Click();

            //Username.SendKeys(username);
            //Password.SendKeys(password);
            //SubmitBtn.Click();
            return new LoginPage(); ;

        }

        public bool IsUserLoggedIn()
        { 
            ;
            var myBluegreen = Driver.instance.FindElement(By.LinkText("my bluegreen"));
            Driver.instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

            return myBluegreen.Enabled;
           
           

        }

    }

}