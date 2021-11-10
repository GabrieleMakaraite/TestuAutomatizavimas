using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestuAutomatizavimas
{
    class ND1
    {


        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }


        [TestCase("2", "2", "4", TestName = "2 plius 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 plius 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a plius b = NaN")]
        public static void TestSeleniumPage(string firstName, string secondName, string result)
        {
            

            //Thread.Sleep(5000);
            //IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            //popUp.Click();

            
            IWebElement firstInput = _driver.FindElement(By.Id("sum1"));                      
            IWebElement secondInput = _driver.FindElement(By.Id("sum2"));
            firstInput.Clear();
            firstInput.SendKeys(firstName);
            secondInput.Clear();
            secondInput.SendKeys(secondName);

            IWebElement button = _driver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            IWebElement resultFromPage = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, resultFromPage.Text, "2 + 2 is not equal to 4");

            
        }
        //[Test]
        //public static void TestSeleniumPage2()
        //{
        //    IWebDriver chrome = new ChromeDriver();
        //    chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

        //    Thread.Sleep(5000);
        //    IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
        //    popUp.Click();

        //    IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
        //    string value1 = "-5";
        //    inputField1.SendKeys(value1);

        //    IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
        //    string value2 = "3";
        //    inputField2.SendKeys(value2);

        //    IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
        //    button.Click();

        //    IWebElement result = chrome.FindElement(By.Id("displayvalue"));
        //    Assert.AreEqual("-2", result.Text, "-5 + 3 is not equal to -2");

        //    chrome.Quit();
        //}
        //[Test]
        //public static void TestSeleniumPage3()
        //{
        //    IWebDriver chrome = new ChromeDriver();
        //    chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

        //    Thread.Sleep(5000);
        //    IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
        //    popUp.Click();

        //    IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
        //    string value1 = "a";
        //    inputField1.SendKeys(value1);

        //    IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
        //    string value2 = "b";
        //    inputField2.SendKeys(value2);

        //    IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
        //    button.Click();

        //    IWebElement result = chrome.FindElement(By.Id("displayvalue"));
        //    Assert.AreEqual("NaN", result.Text, "a + b is not equal to NaN");

        //    chrome.Quit();
        //}
    }
}
