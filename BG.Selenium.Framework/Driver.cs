using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BG.Selenium.Framework
{
    public class Driver
    {
        
        public  static IWebDriver DriverInstance;
    // modify the code to use IE and chrome
        public static void Initialize() => DriverInstance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(@"C:\drivers"));

        public static void CleanUp() => DriverInstance.Close();
   }

}