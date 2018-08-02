using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EATest.Pages;
using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAAutoFramework.Config;
using NUnit.Framework;
using EAAutoFramework.Extensions;

namespace EATest
{
    [TestClass]
    public class UnitTest1 : TestInitializeHook
    {

        /*   public void OpenBrowser(BrowserType type)
           {
               switch (type)
               {
                   case BrowserType.Chrome:
                       break;
                   case BrowserType.Firefox:
                       DriverContext.Driver = new FirefoxDriver(@"F:\C# Framework Material\drivers");
                       DriverContext.Browser = new Browser();
                       break;
               }
           }*/



        [Test]
        public void TestMethod1()
        {

            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Login.xlsx";

            ExcelHelpers.PopulateInCollection(fileName);
            LogHelpers.Write("Test 1 Starts");
            CurrentPage = GetPageInstance<HomePage>();
            CurrentPage = CurrentPage.As<HomePage>().ClickLogin();// as method has to be used because current page at compile time is of base type, but during run time, it will become login page type
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
            CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeList();
            CurrentPage.As<EmployeeList>().ClickCreateNewEmployee();
            CurrentPage.As<CreateNewEmployee>().CreateEmployee("Aditya", 3000, 5, 3, "adita@gmail.com");

            LogHelpers.Write("Test1 Ends");
        }

        /* [Test]
                 public void TableOperation()
                 {
                      string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\Login.xlsx";

                     ExcelHelpers.PopulateInCollection(fileName);
                     LogHelpers.Write("Test Starts");
                     CurrentPage = GetPageInstance<LoginPage>();
                     CurrentPage.As<LoginPage>().clickLogin();// as method has to be used because current page at compile time is of base type, but during run time, it will become login page type
                     CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
                     CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
                     DriverContext.Driver.WaitForDocumentLoaded();
                     var table = CurrentPage.As<EmployeeList>().GetEmployeeList();

                     HtmlTableHelper.ReadTable(table);
                     HtmlTableHelper.PerformActionOnCell("5", "Name", "John", "Edit");
                     DriverContext.Driver.Navigate().Back();


                 }*/



    }
}
