using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestuAutomatizavimas.Drivers;
using TestuAutomatizavimas.Page;
using TestuAutomatizavimas.Tools;

namespace TestuAutomatizavimas.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static DropDownPage _dropDownPage;
        public static VartuTechnikaPage _vartuTechnikaPage;
        public static SenukaiPage _senukaiPage;
        public static AlertPage _alertPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            //driver = CustomDriver.GetChromeDriver();
            driver = CustomDriver.GetIncognitoChromeDriver();
            _dropDownPage = new DropDownPage(driver);

            _vartuTechnikaPage = new VartuTechnikaPage(driver);
            _senukaiPage = new SenukaiPage(driver);
            _alertPage = new AlertPage(driver);
        }
        [TearDown]
        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);

        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
