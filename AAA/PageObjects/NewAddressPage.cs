using AAA.PageObjects.NewAddress.InputData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.PageObjects
{
    public class NewAddressPage
    {
        private IWebDriver driver;

        public NewAddressPage(IWebDriver browser)
        {
            driver = browser;
        }

        private By FirstName = By.Id("input-firstname");
        public IWebElement TxtFirstname => driver.FindElement(FirstName);

        private By LastName = By.Id("input-lastname");
        public IWebElement TxtLastname => driver.FindElement(LastName);

        private By Address1 = By.Id("input-address-1");
        public IWebElement TxtAddress1 => driver.FindElement(Address1);

        private By City = By.Id("input-city");
        public IWebElement TxtCity => driver.FindElement(City);

        private By PostalCode = By.Id("input-postcode");
        public IWebElement TxtPostCode => driver.FindElement(PostalCode);

        private By Country = By.CssSelector("select#input-country");
        public IWebElement DdlCountries => driver.FindElement(Country);

        private By Regiones = By.CssSelector("select#input-zone");
        public IWebElement DdlRegiones => driver.FindElement(Regiones);
        public IList<IWebElement> LstRegiones => driver.FindElements(Regiones);


        private By CreateAddress = By.CssSelector("input[value='Continue']");
        public IWebElement BtnCreateAddress => driver.FindElement(CreateAddress);
        


        public void SaveAddress(string firstName, string lastName, NewAddressBO newAddressBO)
        {
            TxtFirstname.SendKeys(firstName);
            TxtLastname.SendKeys(lastName);
            TxtAddress1.SendKeys(newAddressBO.Address1);
            TxtCity.SendKeys(newAddressBO.City);
            TxtPostCode.SendKeys(newAddressBO.PostCode);
   
            SelectCountry();
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            //wait.Until(ExpectedConditions.ElementToBeClickable(DdlRegiones));
            SelectRegionFromList();
            BtnCreateAddress.Click();
        }
        //LstDefaultAddress[0].Click();
        //BtnContinueAddress.Click();

        public void SelectCountry()
        {
            var selectCountry = new SelectElement(DdlCountries);
            selectCountry.SelectByText("Japan");
        }
        public void SelectRegionFromList()
        {
            foreach (var region in LstRegiones)
            {
                if (region.Text.Equals("Akita"))
                {
                    region.Click();
                    break;
                }
            }
        }
    }

     

}

