using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
    public class Base
    {

     //   private IWebDriver driver { get; set; }
        public static Base CurrentPage { get; set; }

        protected TPage GetPageInstance<TPage>() where TPage : new()
        {
            var pageInstance = new TPage();// object of the page
            //{
             //   driver = DriverContext.Driver
           // };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;

        }

        public TPage As<TPage>() where TPage : Base
        {
            return (TPage)this;// base page object will be type casted as login page automatically
        }
    }
}
