using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class LoginPage
    {
        //declare the driver
        public IWebDriver driver;



        //instantiate the driver
        public LoginPage(IWebDriver browser)
        {
            driver = browser;
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //wait.Until(ExpectedConditions.ElementIsVisible(Email));
        }


        //create our elements
        private By Email = By.Id("input-email");
        private IWebElement TxtEmail => driver.FindElement(By.Id("input-email"));



        private IWebElement TxtPasword => driver.FindElement(By.Id("input-password"));



        private IWebElement BtnSignIn => driver.FindElement(By.CssSelector("[action] .btn-primary"));

        public IWebElement LblLoginSucceded => driver.FindElement(By.XPath("//div[@id='content']/h2[.='My Account']"));

        public IWebElement LblLoginFailed => driver.FindElement(By.XPath("//div[@id='account-login']/div[@class='alert alert-danger alert-dismissible']"));


        public HomePage LoginApplication(string email, string password)
        {
            TxtEmail.SendKeys(email);
            TxtPasword.SendKeys(password);
            BtnSignIn.Click();
            return new HomePage(driver);
        }
    }
}
