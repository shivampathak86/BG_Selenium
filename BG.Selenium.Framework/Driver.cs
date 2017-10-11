using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BG.Selenium.Framework
{
    public class Driver
    {
        
        public  static IWebDriver DriverInstance;
 
        public static void Initialize() => DriverInstance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(@"C:\drivers"));

        public static void CleanUp() => DriverInstance.Close();
   }

}