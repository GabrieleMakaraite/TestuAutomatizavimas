using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestuAutomatizavimas.Page
{
    public class SeleniumDropDownPage : BasePage
    {
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private const string ResultText = "First selected option is : ";
        private const string ResultTextGetAll = "Options selected are : ";
        private IWebElement ResultTextElement => Driver.FindElement(By.CssSelector(".getall-selected"));
        private IWebElement ResultTextGetAllElement => Driver.FindElement(By.CssSelector(".getall-selected"));
        private IWebElement FirstSelectedButton => Driver.FindElement(By.Id("printMe"));
        private IWebElement GetAllSelectedButton => Driver.FindElement(By.Id("printAll"));
        private SelectElement MultiDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));
        public SeleniumDropDownPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }

        public SeleniumDropDownPage SelectFromMultiDropDownByValue(string firstValue, string secondValue)
        {
            Actions action = new Actions(Driver);

            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiDropDown.SelectByValue(secondValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public SeleniumDropDownPage SelectThreeStatesByValue(string firstValue, string secondValue, string thirdValue)
        {
            Actions action = new Actions(Driver);

            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiDropDown.SelectByValue(secondValue);           
            MultiDropDown.SelectByValue(thirdValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public SeleniumDropDownPage SelectFourStatesByValue(string firstValue, string secondValue, string thirdValue, string fourthValue)
        {
            Actions action = new Actions(Driver);

            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiDropDown.SelectByValue(secondValue);
            MultiDropDown.SelectByValue(thirdValue);
            MultiDropDown.SelectByValue(fourthValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }

        public SeleniumDropDownPage ClickFirstSelectedButton()
        {
            FirstSelectedButton.Click();
            return this;
        }

        public SeleniumDropDownPage ClickAllSelectedButton()
        {
            GetAllSelectedButton.Click();
            return this;
        }
        public SeleniumDropDownPage VerifyResultFirst(string selectedState)
        {
            Assert.IsTrue(ResultTextElement.Text.Equals(ResultText + selectedState), $"Result is wrong, not {selectedState}");
            return this;
        }

        public SeleniumDropDownPage VerifyResultGetAllTwoStates(string selectedState1, string selectedState2)
        {
            Assert.IsTrue(ResultTextGetAllElement.Text.Equals(ResultTextGetAll + selectedState1 +","+ selectedState2), $"Result is wrong, not {selectedState1},{selectedState2}");
            return this;
        }

        public SeleniumDropDownPage VerifyResultGetAllFourStates(string selectedState1, string selectedState2, string selectedState3, string selectedState4)
        {
            Assert.IsTrue(ResultTextGetAllElement.Text.Equals(ResultTextGetAll + selectedState1 + "," + selectedState2 + "," + selectedState3 + "," + selectedState4), $"Result is wrong, not {selectedState1},{selectedState2},{selectedState3},{selectedState4}");
            return this;
        }
    }
}
