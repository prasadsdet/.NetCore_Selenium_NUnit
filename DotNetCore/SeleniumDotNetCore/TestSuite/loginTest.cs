using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDotNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * Author : Prasad.Nunna
 * Date Created: 30/06/2020
 * Details : this test has simple Nunit framework with page object model in .Net Core
 * 
 * */
namespace SeleniumDotNetCore.TestSuite
{
    [TestFixture]
    public class loginTest
    {

        public static IWebDriver driver;
        //hooks in NUnit
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This Setup method will execute before each test runs");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void LoginPage()
        {
            HomePage log = new HomePage(driver);
            log.clickLogin();
            LoginPage loginpage = new LoginPage(driver);
            loginpage.LogintoEA("Admin","password");
            Assert.That(log.linkempdetails.Displayed, Is.True);
        }

        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}
