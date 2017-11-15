using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BG.Selenium.Framework
{
   public  class CapturingAction
    {
        public static void  Screenshot()
        {
           
               var screenshot = ((ITakesScreenshot)Driver.DriverInstance).GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\patha\Documents\WorkSpace\GitHub\Selenium\BG\BG_Selenium\BG.Selenium.Framework\Screenshots\SS_"+ DateTime.Now.ToString("yy-MM-dd") +".jpg", ScreenshotImageFormat.Jpeg);
                
           
        }
        public static void CaptureElement(IWebElement element)
        {
            var  js= ((IJavaScriptExecutor)Driver.DriverInstance);
            const string highlightJavascript = @"arguments[0].style.cssText = ""border-width: 3px; border-style: solid; border-color: red"";";
            js.ExecuteScript(highlightJavascript, new object[] {element});
            Screenshot();

        }
    }
}
