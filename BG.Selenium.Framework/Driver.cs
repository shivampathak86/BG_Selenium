using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BG.Selenium.Framework
{
    public class Driver
    {
        //public static IWebDriver FFdriver = new FirefoxDriver( FirefoxDriverService.CreateDefaultService(@"C:\drivers"));
        public  static IWebDriver DriverInstance;

        //public static ISearchContext IsearchContext
        //{
        //    get
        //    {
        //        return FFdriver;
        //    }
        //}
        public static void Initialize() => DriverInstance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(@"C:\drivers"));

        public static void CleanUp() => DriverInstance.Close();
   }

}