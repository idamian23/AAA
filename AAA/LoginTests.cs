using AAA.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AAA
{
  
    
    [TestClass]
  
public class LoginTests
    {
        //declare IwebDriver instance 
        //declare it outside of any method so that we can use it in various methods
        private IWebDriver driver;

        //declare the LoginPage class
        private LoginPage loginPage;



        [TestInitialize]
        public void SetUp()
        {
            //open browser
            driver = new ChromeDriver();
            //init login page
            loginPage = new LoginPage(driver);
            //maximize windows
            driver.Manage().Window.Maximize();
            //access URL 
            driver.Navigate().GoToUrl("http://tutorialsninja.com/demo/index.php?route=account/login");
            Thread.Sleep(500); //BAD BAD PRACTICE
        }

        [TestMethod]
        public void Should_login_successfully_with_valid_credentials()
        {

            var homePage = loginPage.LoginApplication("test45@test.com", "test123");
            

            //assert that the email is correct
            Assert.AreEqual(homePage.LblLoggedIn.Text , loginPage.LblLoginSucceded.Text);
        }




        [TestMethod]
        public void Should_fail_login_with_invalid_credentials()
        {
           
            loginPage.LoginApplication("random100@random.com", "random");
            //assert that the login failed
            var errorMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(loginPage.LblLoginFailed.Text, errorMessage);
        }

        [TestCleanup]
        public void CleanUp()
        {
            //quit the driver instance
            driver.Quit();
        }



    }
}
