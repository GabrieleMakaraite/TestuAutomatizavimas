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
    public class SeleniumCheckboxTest
    {
        private static SeleniumCheckboxPage _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            //_driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new SeleniumCheckboxPage(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_page.CloseBrowser();
        }

        [Order(1)]
        [Test]
        public void TestSingleCheckbox()
        {
            //SeleniumCheckboxPage page = new SeleniumCheckboxPage(_driver);
            //string expectedResult = "Success - Check box is checked";

            _page.CheckSingleCheckbox().SingleCheckboxResult("Success - Check box is checked");        
        }

        [Order(2)]
        [Test]
        public void TestMultipleCheckbox()
        {
            //SeleniumCheckboxPage page = new SeleniumCheckboxPage(_driver);
            _page.CheckMultipleCheckbox().MultipleCheckboxResult("Uncheck all").ClickButton().VerifyAllCheckboxesAreUnchecked();
        }

    }
}
