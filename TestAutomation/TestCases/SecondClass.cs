using CSPPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.TestCases
{
    [TestFixture]

    
    public class SecondClass
    {

        [SetUp]
        public void setup()
        {
            //IWebDriver driver = new FirefoxDriver();
            //LaunchPage lPage = new LaunchPage(driver);
            //PageFactory.InitElements(driver, lPage);
            //Login l = lPage.goToLoginPage();
            //CSPPages.Pages.Support home = l.dologin("lhaskin@arizona.aaa.com.staging", "Communitytest3");
        }
        [Test]//Login Succesfully into CSP
        public void LoginIntoCsp()
        {
            IWebDriver driver = new FirefoxDriver();
            LaunchPage lPage = new LaunchPage(driver);
            PageFactory.InitElements(driver, lPage);
            Login l = lPage.goToLoginPage();
            CSPPages.Pages.Support home= l.dologin("enterprisedemo@andyluciani.com.staging", "Ultimate01");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Assert.True(home.HomeImage.Displayed);
       
        }
        [Test]//Login with incorrect Password

        public void LoginIncorrectPassword()
        {
            IWebDriver driver = new FirefoxDriver();
            LaunchPage lPage = new LaunchPage(driver);
            PageFactory.InitElements(driver, lPage);
            Login l = lPage.goToLoginPage();
            CSPPages.Pages.Support home = l.dologin("enterprisedemo@andyluciani.com.staging", "Ultimate02");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Assert.AreEqual(l.Errormessage.Text,"Your login attempt has failed. Make sure the username and password are correct.");
 
        }


        [Test]//Click on Support Tab
        public void TestSupport()
        {
            IWebDriver driver = new FirefoxDriver();
            LaunchPage lPage = new LaunchPage(driver);
            PageFactory.InitElements(driver, lPage);
            Login l = lPage.goToLoginPage();
            CSPPages.Pages.Support home = l.dologin("lhaskin@arizona.aaa.com.staging", "Communitytest3");
            home.ClickSupport();
            
           // Assert.AreEqual(driver.Title, "Support");
           
         
      }
        [Test]//Clicking the project center tab
        public void TestProjectCenter()
        {

            IWebDriver driver = new FirefoxDriver();
            LaunchPage lPage = new LaunchPage(driver);
            PageFactory.InitElements(driver, lPage);
            Login l = lPage.goToLoginPage();
            CSPPages.Pages.Support home = l.dologin("lhaskin@arizona.aaa.com.staging", "Communitytest3");
            ProjectCenter Project = new ProjectCenter(driver);
            PageFactory.InitElements(driver, Project);


        }
       
      
      
    }
}
