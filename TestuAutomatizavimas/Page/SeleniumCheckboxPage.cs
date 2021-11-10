using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestuAutomatizavimas.Page
{
    class SeleniumCheckboxPage
    {
        private static IWebDriver _driver;
        public IWebElement _singleCheckbox => _driver.FindElement(By.Id("isAgeSelected"));
        public IWebElement _singleResult => _driver.FindElement(By.Id("txtAge"));
        public IReadOnlyCollection<IWebElement> _multipleCheckboxList => _driver.FindElements(By.CssSelector(".cb1-element"));
        public IWebElement _button => _driver.FindElement(By.Id("check1"));
        public SeleniumCheckboxPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }


        public SeleniumCheckboxPage CheckSingleCheckbox()
        {
            _singleCheckbox.Click();
            return this;
        }

        public SeleniumCheckboxPage SingleCheckboxResult(string expectedResult)
        {
            Assert.IsTrue(_singleResult.Text.Contains(expectedResult), "Result is not the same");
            return this;
        }

        public SeleniumCheckboxPage CheckMultipleCheckbox()
        {
           
            foreach (IWebElement element in _multipleCheckboxList)
            {
                element.Click();
            }

            return this;
        }
        public SeleniumCheckboxPage MultipleCheckboxResult()
        {
            _button.GetProperty("value");
            Assert.IsTrue(_button.GetProperty("value").Equals("Uncheck All"));

            _button.Click();
            _button.GetProperty("value");
            Assert.IsTrue(_button.GetProperty("value").Equals("Check All"));

            return this;
        }


    }
}
