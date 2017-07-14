using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPages.Pages
{
   public class TopMenu
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='ask-for-help-dropdown']/ul/li[13]/a/p")]
        public IWebElement signout;
        public void logout()
        { }
        public void goToWatchList()
        {

        }
    }
}
