using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestuAutomatizavimas.Page;

namespace TestuAutomatizavimas.Test
{
    class SeleniumDropDownTest
    {
        private static SeleniumDropDownPage _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            _page = new SeleniumDropDownPage(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_page.CloseBrowser();
        }

        [Order(1)]
        [Test]
        public void TestMultiDropDownFirstSelected()
        {
            _page.SelectFromMultiDropDownByValue("Texas", "Washington")
                .ClickFirstSelectedButton();//.VerifyResultFirst("Texas");
        }

        [Order(2)]
        [Test]
        public void TestMultiDropDownGetAllSelected()
        {
            _page.SelectFromMultiDropDownByValue("Texas", "Washington").ClickAllSelectedButton();//.VerifyResultGetAllTwoStates("Texas","Washington");
        }

        [Order(3)]
        [Test]
        public void TestMultiDropDownThreeStates()
        {
            _page.SelectThreeStatesByValue("New York", "Florida", "Ohio").ClickFirstSelectedButton();//.VerifyResultFirst("New York");
        }

        [Order(4)]
        [Test]
        public void TestMultiDropDownFourStates()
        {
            _page.SelectFourStatesByValue("Florida", "Ohio", "California", "New Jersey").ClickAllSelectedButton();//.VerifyResultGetAllFourStates("Florida", "Ohio", "California", "New Jersey");
        }
    }
}
