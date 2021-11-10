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
    public class VartuTechnikaTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            //_driver.Url = "http://vartutechnika.lt/";
            _driver.Navigate().GoToUrl("http://vartutechnika.lt/");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("cookiescript_reject")).Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98", TestName = "2000 x 2000 + Vartu automatika = 665.98e")]
        public void TestVartuTechnika(string width, string height, bool automatika, bool montavimoDarbai, string result)
        {
            VartuTechnikaPage page = new VartuTechnikaPage(_driver);
            page.InsertWidthAndHeight(width, height)
            .CheckAutomatikaCheckbox(automatika)
            .CheckMontavimoCheckbox(montavimoDarbai)
            .ClickCalculateButton()
            .CheckResult(result);
        }



    }
}
