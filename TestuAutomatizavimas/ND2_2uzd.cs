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
    class ND2_2uzd
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);          
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]       
        public static void TestSingleCheckBox()
        {
            _driver.FindElement(By.Id("isAgeSelected")).Click();           
            IWebElement result = _driver.FindElement(By.Id("txtAge"));
            Assert.IsTrue(result.Text.Contains("Success - Check box is checked"), "Check box is not checked.");
        }
        [Test]
        public static void TestMultipleCheckBox()
        {

            IReadOnlyCollection<IWebElement> multipleCheckboxList = _driver.FindElements(By.CssSelector(".cb1-element"));           
            foreach (IWebElement element in multipleCheckboxList)
            {
                element.Click();
            }
            
            
            IWebElement button = _driver.FindElement(By.Id("check1"));
            button.GetProperty("value");
            Assert.IsTrue(button.GetProperty("value").Equals("Uncheck All"));

            button.Click();
            button.GetProperty("value");
            Assert.IsTrue(button.GetProperty("value").Equals("Check All"));




            

        }
    }
} 
