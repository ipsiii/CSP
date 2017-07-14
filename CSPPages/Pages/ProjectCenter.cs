using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace CSPPages.Pages
{
  public  class ProjectCenter:BasePage
    {
        
        [FindsBy(How = How.CssSelector, Using = "#NapiliCommunityTemplate > div:nth-child(3) > div > header > div.slds-col.nav-col > nav.slds-medium-show > ul > li:nth-child(2) > a > span")]
        public IWebElement ProjectCenterTab;
        public ProjectCenter(IWebDriver dr):base(dr)
        {
            

        }

        public void ClickProjectCenter()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            ProjectCenterTab.Click();


        }



    }
}
