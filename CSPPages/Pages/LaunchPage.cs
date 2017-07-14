using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPages.Pages
{
    public class LaunchPage:BasePage
    {

        
        public LaunchPage(IWebDriver dr):base(dr)
        {
           
        }

        public Login goToLoginPage()
        {
            //Webdriver code
            driver.Url = "https://staging-ultimate.cs17.force.com/csp/s/login/?startURL=%2Fcsp%2Fs%2F%3Ftabset-712fe%3D1&ec=302";
            Login l = new Login(driver);
            PageFactory.InitElements(driver, l);
            return l;
        }
    }
}
