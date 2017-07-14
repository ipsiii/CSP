using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace CSPPages.Pages
{
    public class Support:BasePage
    {

        

        [FindsBy(How = How.CssSelector, Using = "#NapiliCommunityTemplate > div:nth-child(3) > div > header > div.slds-col.nav-col > nav.slds-medium-show > ul > li:nth-child(1) > a > span")]
         public IWebElement SupportTab;
        [FindsBy(How = How.XPath, Using = ".//*[@id='ulti-logo']/a/img")]
        public IWebElement HomeImage;



        public Support(IWebDriver dr):base(dr)
        {
            
            
        }
       

        public void  ClickSupport()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            SupportTab.Click();
            string get = driver.CurrentWindowHandle;
            
           
      
        }
        
    }
}
