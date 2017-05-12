using CSPPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.TestCases
{
    [TestFixture]
    public class TestCase1
    {
        [Test]
        public void TestLogin()
        {
           LaunchPage lpage = new LaunchPage();
           Login loginpage= lpage.goToLoginPage();
           Support supportpage=loginpage.dologin("xxx", "xxx");
           Support.verifyLogin();
           Assert.Pass("Your first passing test");
        }
    }
}
