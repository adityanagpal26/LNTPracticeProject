using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATest.Pages
{
    class HomePage:Base
    {
        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement lnkLogin { get; set; }


        [FindsBy(How = How.LinkText, Using = "Employee List")]
        public IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How=How.PartialLinkText, Using = "Hello")]
        public IWebElement lnkUsername { get; set; }

        public LoginPage ClickLogin()
        {
            lnkLogin.Click();
            return GetPageInstance<LoginPage>();
        }

        public EmployeeList ClickEmployeeList()
        {
            lnkEmployeeList.Click();
            return GetPageInstance<EmployeeList>();
        }

        public void AssertHomePage()
        {
            lnkLogin.AssertElementPresent();
        }

        public string UserNameDisplayedAfterLogin()
        {
            return lnkUsername.GetText();
        }

    }
}
