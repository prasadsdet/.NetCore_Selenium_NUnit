using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
/*
 * 
 * Author : Prasad.Nunna
 * Date Created: 30/06/2020
 * Details : this test has simple Nunit framework to initilise driver load page in .Net Core
 * 
 * */
namespace SeleniumDotNetCore
{
    [TestFixture]
    public class Tests
    {
        public static IWebDriver driver;
        //hooks in NUnit
        [SetUp]
        public void Setup()
        {
           // open the browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            IWebElement loginlink = driver.FindElement(By.Id("loginLink"));
            loginlink.Click();
            var txtusername = driver.FindElement(By.Id("UserName"));
            Assert.That(txtusername.Displayed, Is.True);
            txtusername.SendKeys("Admin");
            var txtxpassword = driver.FindElement(By.Id("Password"));
            Assert.That(txtxpassword.Displayed, Is.True);
            txtxpassword.SendKeys("password");
            driver.FindElement(By.XPath("//input[@type='submit']")).Submit();

            var linkempdetails = driver.FindElement(By.LinkText("Employee Details"));
            Assert.That(linkempdetails.Displayed, Is.True);
        }

        [Test]
        public void Test1()
        {
            Assert.That(false);
        }
        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}