using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPages.Pages
{
   public class BasePage
    {
        public IWebDriver driver;
        public TopMenu menu;
        public BasePage(IWebDriver dr)
        {
            driver = dr;
        }
  
        public bool verifyTitle(string expTitle)
        {
            return false;
        }

    }
}
