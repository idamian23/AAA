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
    public class EditAccountTest
    {
        private IWebDriver driver;
        private AccountInfPage accountInfPage;



        [TestInitialize]
        public void TestSetUp()
        {
            driver = new ChromeDriver();
            var loginPage = new LoginPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://tutorialsninja.com/demo/index.php?route=account/login");
            Thread.Sleep(500);
            var myAccount = loginPage.LoginApplication("test45@test.com", "test123");
            Thread.Sleep(500);
            accountInfPage = myAccount.NavigateToAccountInfoPage();
            Thread.Sleep(500);
        }



        [TestMethod]
        public void Should_Edit_Account()
        {
            accountInfPage.SaveEditAccount();
            Thread.Sleep(500);
        }




        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }
    }
}
