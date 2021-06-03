using AAA.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AAA
{
    [TestClass]
    public class RegisterTest
    {
        private IWebDriver driver;
        private RegisterPage registerPage;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            registerPage = new RegisterPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://tutorialsninja.com/demo/index.php?route=account/register");
            Thread.Sleep(500); //BAD BAD PRACTICE
        }
        [TestMethod]
        public void ShouldSuccesfullyRegisterAccount()
        {
            registerPage.Register("test111","tes3t2","test541@test.com","0756734734","test123","test123"); 
            var message = "Your Account Has Been Created!";
            Assert.AreEqual(message, registerPage.LblSuccededRegistration.Text);
        }

        [TestCleanup]
        public void CleanUp()
        {
            //quit the driver instance
            driver.Quit();
        }

    }
}
