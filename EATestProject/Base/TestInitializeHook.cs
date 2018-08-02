using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAAutoFramework.Base
{
    [Binding]
    public class TestInitializeHook : Base
    {
        // [OneTimeSetUp]//this is to run with nunit
        [BeforeTestRun]// this is for specflow
        public static void SetUpLogFile()
        {
            ConfigReader.SetFrameworkSettings();
            LogHelpers.CreateLogFile();
        }

        // [SetUp]
        [BeforeScenario]
        public static void InitializeSettings()
        {
            OpenBrowser(Settings.Browser);
         //   DriverContext.Browser.GoToUrl(Settings.AUT);
        }

        // [TearDown]
        [AfterScenario]
        public static void TearDown()
        {
            DriverContext.Driver.Close();
            ExcelHelpers.UnpopulateExcelInCollection();
        }

        private static void OpenBrowser(string type)
        {
            switch (type)
            {
                case "Chrome":
                    break;
                case "Firefox":
                    DriverContext.Driver = new FirefoxDriver(@"F:\C# Framework Material\drivers");
                    DriverContext.Browser = new Browser();
                    break;
            }
        }

        
    }
}
