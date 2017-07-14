using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSPPages.Pages
{
    public class Login:BasePage
    {
        

        [FindsBy(How = How.ClassName, Using = "sfdc_usernameinput")]
        public IWebElement usernamefield;
        [FindsBy(How = How.ClassName, Using = "sfdc_passwordinput")]
        public IWebElement passwordfield;
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div/div[2]/div/div[2]/div/div[3]/button")]
        public IWebElement Submit;
        [FindsBy(How = How.XPath, Using = ".//*[@id='error']/div")]
        public IWebElement Errormessage;
        public Login(IWebDriver dr):base(dr)
        {
            
        }

        public Support dologin(string username, string password)
        {
             Thread.Sleep(2000);
           
            usernamefield.SendKeys(username);
            passwordfield.SendKeys(password);
            Submit.Click();
          
            Support home = new Support(driver);
            
            PageFactory.InitElements(driver, home);
            return home;
        }
    }
}
