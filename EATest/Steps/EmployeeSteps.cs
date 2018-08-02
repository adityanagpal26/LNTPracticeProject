using EAAutoFramework.Base;
using EATest.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EATest.Steps
{
    [Binding]
    public class EmployeeSteps:BaseStep
    {
        

        [Then(@"I enter following details")]
        public void ThenIEnterFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<CreateNewEmployee>().CreateEmployee(data.Name.ToString(), Convert.ToDecimal(data.Salary), Convert.ToInt32(data.DurationWorked), Convert.ToInt32(data.Grade), data.Email.ToString());

        }
    }
}
