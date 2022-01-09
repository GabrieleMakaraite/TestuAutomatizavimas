using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestuAutomatizavimas.Page
{
    public class SeleniumCheckboxPage : BasePage
    {      
        public IWebElement _singleCheckbox => Driver.FindElement(By.Id("isAgeSelected"));
        public IWebElement _singleResult => Driver.FindElement(By.Id("txtAge"));
        public IReadOnlyCollection<IWebElement> _multipleCheckboxList => Driver.FindElements(By.CssSelector(".cb1-element"));
        public IWebElement _button => Driver.FindElement(By.Id("check1"));
        public SeleniumCheckboxPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
        }


        public SeleniumCheckboxPage CheckSingleCheckbox()
        {
            if (!_singleCheckbox.Selected)
                _singleCheckbox.Click();

            return this;
        }

        public SeleniumCheckboxPage SingleCheckboxResult(string expectedResult)
        {
            Assert.IsTrue(_singleResult.Text.Contains(expectedResult), "Result is not the same");
            return this;
        }

        private void UncheckFirstBlockCheckbox()
        {
            if (_singleCheckbox.Selected)
                _singleCheckbox.Click();
        }

        public SeleniumCheckboxPage CheckMultipleCheckbox()
        {
            UncheckFirstBlockCheckbox();
            foreach (IWebElement element in _multipleCheckboxList)
            {
                element.Click();
            }

            return this;
        }
        public SeleniumCheckboxPage MultipleCheckboxResult(string value)
        {          
            return this;
        }

        public SeleniumCheckboxPage ClickButton()
        {
            _button.Click();
            return this;
        }
        public SeleniumCheckboxPage VerifyAllCheckboxesAreUnchecked()
        {
            foreach (IWebElement element in _multipleCheckboxList)
            {
                Assert.False(element.Selected, "Checkbox is still checked");
                //Assert.IsTrue(!element.Selected, "Checkbox is still checked");
                //Assert.That(!element.Selected, "Checkbox is still checked");
            }
            return this;
        }


    }
}
