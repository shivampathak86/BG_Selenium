using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace BG.Selenium.Framework
{
    public class Driver
    {
        
        public  static IWebDriver instance;
        public static void  Initialize()
        {
            var driverService = FirefoxDriverService.CreateDefaultService(@"C:\drivers");
            instance = new FirefoxDriver(driverService);


           
        }
       
        public static void CleanUp()
        {

            Driver.instance.Close();
        }
    }
}