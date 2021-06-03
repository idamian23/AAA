using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver browser)
        {
            driver = browser;
        }

        private By confirmation = By.XPath("//div[@id='content']/h2[.='My Account']");
        public IWebElement LblLoggedIn => driver.FindElement(confirmation);

        private By address = By.CssSelector("div > a:nth-of-type(4)");
        private By addressConfirmation = By.CssSelector(".btn.btn-primary");
        public IWebElement BtnAddresses => driver.FindElement(address);
        //public IWebElement BtnAddressesConfirmation => driver.FindElement(addressConfirmation);

        private By Email = By.XPath("//div[@id='content']/h2[.='My Account']");
        public IWebElement LbEmail => driver.FindElement(Email);

        private By AccountInfoPage = By.XPath("//div[@id='content']/ul[1]//a[@href='http://tutorialsninja.com/demo/index.php?route=account/edit']");
        public IWebElement BtnEditAccount => driver.FindElement(AccountInfoPage);


        public AddressesPage NavigateToAddAddresesPage()
        {

            BtnAddresses.Click();
            //BtnAddressesConfirmation.Click();
            return new AddressesPage(driver);
        }

        public AccountInfPage NavigateToAccountInfoPage()
        {
            BtnEditAccount.Click();
            return new AccountInfPage(driver);
        }



    }
}
