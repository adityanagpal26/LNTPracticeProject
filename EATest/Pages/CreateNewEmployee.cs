using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATest.Pages
{
    class CreateNewEmployee:Base
    {
        [FindsBy(How=How.Id, Using = "Name")]
        public IWebElement txtName { get; set; }
        [FindsBy(How = How.Id, Using = "Salary")]
        public IWebElement txtSalary { get; set; }
        [FindsBy(How = How.Id, Using = "DurationWorked")]
        public IWebElement txtDuration { get; set; }
        [FindsBy(How = How.Id, Using = "Grade")]
        public IWebElement txtGrade { get; set; }
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtEmail { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement btnCreate { get; set; }

        public void CreateEmployee(string name, decimal salary, int duration, int grade, string email)
        {
            txtName.SendKeys(name);
            txtSalary.SendKeys(Convert.ToString(salary));
            txtDuration.SendKeys(Convert.ToString(duration));
            txtGrade.SendKeys(Convert.ToString(grade));
            txtEmail.SendKeys(email);
           
        }

        public EmployeeList ClickCreateButton()
        {
            btnCreate.Click();
            return GetPageInstance<EmployeeList>();
        }

    }
}
