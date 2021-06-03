using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.Utils
{
    public class WaitHelpers
    {
        public static void WaitElementToBeVisible(IWebDriver driver, By by, int timeSpan = 30)
        {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeSpan));
        wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
