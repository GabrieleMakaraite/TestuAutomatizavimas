using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestuAutomatizavimas.Page
{
    public class SenukaiPage : BasePage
    {
        private const string PageAddress = "https://www.senukai.lt/";
        
        
        private IWebElement ResultTextElement => Driver.FindElement(By.CssSelector(".selected-value"));
        
        public SenukaiPage(IWebDriver webdriver) : base(webdriver)
        {
            //Driver.Url = PageAddress;
        }
        public SenukaiPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public SenukaiPage AcceptCookie()
        {
            Cookie myCookie = new Cookie("CookieConsent", 
                "{stamp:%27i0a+Uq259FisCRjWY5a1JM3J1c0e4sCpcQVls77ApK+8nIJJlkZ19g==%27%2Cnecessary:true%2Cpreferences:false%2Cstatistics:false%2Cmarketing:false%2Cver:1%2Cutc:1637340115335%2Cregion:%27lt%27}, " +
                "www.senukai.lt", "/", DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }
    }
}
