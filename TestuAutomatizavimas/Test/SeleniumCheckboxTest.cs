using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestuAutomatizavimas.Page;

namespace TestuAutomatizavimas.Test
{
    class SeleniumCheckboxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();           
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();            
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void TestSingleCheckbox()
        {
            SeleniumCheckboxPage page = new SeleniumCheckboxPage(_driver);
            string expectedResult = "Success - Check box is checked";

            page.CheckSingleCheckbox().SingleCheckboxResult(expectedResult);        
        }

        [Test]
        public void TestMultipleCheckbox()
        {
            SeleniumCheckboxPage page = new SeleniumCheckboxPage(_driver);
            page.CheckMultipleCheckbox().MultipleCheckboxResult();
        }

    }
}
