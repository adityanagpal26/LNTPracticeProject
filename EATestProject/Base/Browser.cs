using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
    public class Browser
    {
     /*   public IWebDriver Driver { get;  }

        public Browser(IWebDriver driver)
        {
            Driver = driver;
        }*/

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }

    public enum BrowserType
    {
        InternetExplorer,
        Chrome,
        Firefox
    }
}
