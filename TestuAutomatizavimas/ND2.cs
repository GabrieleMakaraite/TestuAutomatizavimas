using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestuAutomatizavimas
{
    class ND2
    {
        [Test]
        public static void TestChromeDriver()
        {                       
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#pars";
            chrome.Manage().Window.Maximize();

            IWebElement resultFromPage = chrome.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual("Chrome 95 on Windows 10", resultFromPage.Text, "Web Driver is not Chrome");

            chrome.Quit();           
        }

        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#pars";
            firefox.Manage().Window.Maximize();

            IWebElement resultFromPage = firefox.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual("Firefox 94 on Windows 10", resultFromPage.Text, "Web Driver is not Firefox");

            firefox.Quit();
        }
    }
}
