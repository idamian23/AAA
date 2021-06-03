using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class AccountInfPage
    {
        private IWebDriver driver;



        public AccountInfPage(IWebDriver browser)
        {
            driver = browser;
        }



        private By FirstName = By.Id("input-firstname");
        public IWebElement TxTFirstName => driver.FindElement(FirstName);



        private By LastName = By.Id("input-lastname");
        public IWebElement TxTLastName => driver.FindElement(LastName);



        private By EmailAcc = By.Id("input-email");
        public IWebElement TxTEmailAcc => driver.FindElement(EmailAcc);



        private By Telephone = By.Id("input-telephone");
        public IWebElement TxTTelephone => driver.FindElement(Telephone);



        public void SaveEditAccount()
        {
            TxTFirstName.SendKeys("a");
            TxTLastName.SendKeys("");
            TxTEmailAcc.SendKeys("");
            TxTTelephone.SendKeys("50");
        }



    }
}
