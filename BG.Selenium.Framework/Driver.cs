using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BG.Selenium.Framework
{
    public class Driver
    {
        
        public  static IWebDriver DriverInstance;
 
        public static void Initialize() => DriverInstance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(@"C:\drivers"));


        //public static void SwitchingWindows()
        //{
        //    IList<string> windows = DriverInstance.WindowHandles;
        //    foreach (var window in windows)
        //    {

        //        DriverInstance.SwitchTo().Window(window);
        //    }
        //}

        public static void CleanUp() => DriverInstance.Quit();
   }

}