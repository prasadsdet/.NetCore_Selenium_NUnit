using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDotNetCore.Pages
{
    public class LoginPage
    {
        private IWebDriver driver { get; }
        public LoginPage(IWebDriver Driver)
        {
            driver = Driver;
        }

        IWebElement txtusername => driver.FindElement(By.Id("UserName"));
        IWebElement txtpassword => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//input[@type='submit']"));

        public void LogintoEA(string username,string password)
        {
            txtusername.SendKeys(username);
            txtpassword.SendKeys(password);
            loginbtn.Submit();


        }
    }
}
