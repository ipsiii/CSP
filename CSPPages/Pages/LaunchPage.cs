using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPPages.Pages
{
    public class LaunchPage
    {
        public Login goToLoginPage()
        {
            //Webdriver code
            return new Login();
        }
    }
}
