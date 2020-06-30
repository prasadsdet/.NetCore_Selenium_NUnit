using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNetCore.Pages
{
    public class HomePage
    {
        private IWebDriver driver { get; }
        public HomePage(IWebDriver WebDriver)
        {
            driver = WebDriver;
        }
        public IWebElement lnklogin => driver.FindElement(By.Id("loginLink"));
        public IWebElement linkempdetails => driver.FindElement(By.LinkText("Employee Details"));

        public void clickLogin() => lnklogin.Click();
    }
}
