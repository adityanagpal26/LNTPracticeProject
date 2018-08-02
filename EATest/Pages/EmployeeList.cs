using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Base;


namespace EATest.Pages
{
    
    class EmployeeList:Base
    {

      
        [FindsBy(How=How.CssSelector,Using = "a.btn")]
        public IWebElement btnCreateNewEmployee { get; set; }
        [FindsBy(How=How.ClassName, Using ="table")]
        public IWebElement tblEmployeeList { get; set; }

        public CreateNewEmployee ClickCreateNewEmployee()
        {
            btnCreateNewEmployee.Click();
            return GetPageInstance<CreateNewEmployee>();
        }

        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }
    }
}
