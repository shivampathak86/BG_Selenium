using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace BG.Selenium.Framework
{
    public class Driver
    {

        public static IWebDriver DriverInstance;
        
        public static void Initialize()
        {
            System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"C:\drivers\geckodriver.exe");
            DriverInstance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(@"C:\drivers"));
        }


        //public static void SwitchingWindows()
        //{
        //    IList<string> windows = DriverInstance.WindowHandles;
        //    foreach (var window in windows)
        //    {

        //        DriverInstance.SwitchTo().Window(window);
        //    }
        //}

        public static void CleanUp()
        {

            //System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"C:\drivers");
            DriverInstance.Quit();
        }

    }
}