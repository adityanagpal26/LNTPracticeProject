using System;
using TechTalk.SpecFlow;
using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Extensions;
using EATest.Pages;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace EATest.Steps
{
    [Binding]
    public class LoginSteps:BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetPageInstance<HomePage>();
        }
        
        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().AssertHomePage();
        }
        
        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }
        
        [Then(@"I click (.*) link")]
        public void ThenIClickLoginLink(string page)
        {
            if (page.Equals("Login"))
                CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
            else if (page.Equals("EmployeeList"))
                CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeList();
        }
        
        [Then(@"I click (.*) button")]
        public void ThenIClickLoginButton(string button)
        {
            if(button.Equals("login"))
            CurrentPage=CurrentPage.As<LoginPage>().ClickLogin();
            else if (button.Equals("createnew"))
            {
                CurrentPage = CurrentPage.As<EmployeeList>().ClickCreateNewEmployee();
            }
            else if (button.Equals("create"))
            {
                CurrentPage = CurrentPage.As<CreateNewEmployee>().ClickCreateButton();
            }
        }
        
        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            Assert.IsTrue(CurrentPage.As<HomePage>().
                UserNameDisplayedAfterLogin().Contains("admin"),"Username not displayed after log in" );
        }
    }
}
