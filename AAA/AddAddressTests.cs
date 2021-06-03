using AAA.PageObjects;
using AAA.PageObjects.NewAddress.InputData;
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
    public class AddAddressTests 
    { 

        private IWebDriver driver;
        private NewAddressPage newAddressPage;
    
        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            var loginPage = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://tutorialsninja.com/demo/index.php?route=account/login");
            Thread.Sleep(500); //BAD BAD PRACTICE
            var homePage = loginPage.LoginApplication("test45@test.com", "test123");
            
            var addressesPage = homePage.NavigateToAddAddresesPage();
            
            newAddressPage = addressesPage.NavigateToNewAddressPage();
            Thread.Sleep(500); //BAD BAD PRACTICE
        }

        [TestMethod]
        public void ShouldSuccesfullyAddNewAddress()
        {
            var newAddressBO = new NewAddressBO()
            {
                FirstName = "NewFirstName",
                City = "Iasi"
            };
            newAddressPage.SaveAddress("first", "last", newAddressBO);
            var message = " Your address has been successfully added";
            var successfullyAddedAddressPage = new SuccesfullyAddedAddressPage(driver);
            Assert.AreEqual(message, successfullyAddedAddressPage.LblSuccesfullyAdded.Text);
            
        }




    [TestCleanup]
        public void TestCleanup()
        {
            //driver.Quit();
        }
    }
}
