using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class SuccesfullyAddedAddressPage
    {
        private IWebDriver driver;

        public SuccesfullyAddedAddressPage(IWebDriver browser)
        {
            driver = browser;

        }

        private By SuccesfullyAdded = By.CssSelector("div#account-address > .alert.alert-dismissible.alert-success");
        public IWebElement LblSuccesfullyAdded => driver.FindElement(SuccesfullyAdded);
    }
}
