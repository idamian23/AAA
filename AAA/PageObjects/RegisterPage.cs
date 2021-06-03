using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class RegisterPage
    {
        private IWebDriver driver;

        public RegisterPage(IWebDriver browser)
        {
            driver = browser;
        }

        private IWebElement TxtFirstName => driver.FindElement(By.Id("input-firstname"));
        private IWebElement TxtLastName => driver.FindElement(By.Id("input-lastname"));

        private IWebElement TxtEmail => driver.FindElement(By.Id("input-email"));

        private IWebElement TxtPhone => driver.FindElement(By.Id("input-telephone"));

        private IWebElement TxtPassword => driver.FindElement(By.Id("input-password"));

        private IWebElement TxtPasswordConfirmation => driver.FindElement(By.Id("input-confirm"));

        private IWebElement BtnPolicyAgreement => driver.FindElement(By.Name("agree"));

        private IWebElement BtnSubmit => driver.FindElement(By.CssSelector("input[value='Continue']"));

        public IWebElement LblSuccededRegistration => driver.FindElement(By.XPath("//div[@id='content']/h1[.='Your Account Has Been Created!']"));

        public void Register(string firstName, string lastName, string email, string phoneNumber, string password
            , string confirmedPassword)
        {
            TxtFirstName.SendKeys(firstName);
            TxtLastName.SendKeys(lastName);
            TxtEmail.SendKeys(email);
            TxtPhone.SendKeys(phoneNumber);
            TxtPassword.SendKeys(password);
            TxtPasswordConfirmation.SendKeys(confirmedPassword);
            BtnPolicyAgreement.Click();
            BtnSubmit.Click();
            
        }


    }
}
