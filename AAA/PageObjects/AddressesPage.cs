using AAA.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class AddressesPage
    {
        private IWebDriver driver;

        public AddressesPage(IWebDriver browser)
        {
            driver = browser;
        }

        private By NewAddress = By.CssSelector(".btn.btn-primary");
        public IWebElement BtnNewAddress => driver.FindElement(NewAddress);


        public NewAddressPage NavigateToNewAddressPage()
        {
            WaitHelpers.WaitElementToBeVisible(driver, NewAddress);
            BtnNewAddress.Click();
            return new NewAddressPage(driver);
        }

    }
}
