using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestuAutomatizavimas.Drivers;
using TestuAutomatizavimas.Page;

namespace TestuAutomatizavimas.Test
{
    public class DropDownTest : BaseTest
    {
        
        [Test]
        public void TestDropDown()
        {
            _dropDownPage.NavigateToDefaultPage().SelectFromDropdownByText("Friday")
                .VerifyResult("Friday");
        }

        [Test]
        public void TestMultiDropDown()
        {
            _dropDownPage.NavigateToDefaultPage().SelectFromMultiDropDownByValue("Ohio", "Florida")
                .ClickFirstSelectedButton();
        }

    }
}
