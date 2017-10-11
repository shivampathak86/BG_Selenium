using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Selenium.Framework
{
    public  class Pages
    {  
        
        public static LoginPage Loginpage
        {

            get
            {
               var loginPage = new LoginPage();
                PageFactory.InitElements(Driver.DriverInstance, loginPage);
                return loginPage;
            }
        }

        public static object Bookreservation
        {
            get
            {
                var bookreservation = new HomePage();
                PageFactory.InitElements(Driver.DriverInstance, bookreservation);
                return bookreservation;
            }



        }
    }
}
