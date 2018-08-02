using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Extensions;

namespace EATest.Pages
{
    class LoginPage:Base
    {
       
        [FindsBy(How =How.LinkText, Using = "Login")]
        public IWebElement lnkLogin { get; set; }
        [FindsBy(How=How.Id, Using ="UserName")]
        public IWebElement txtUsername { get; set; }
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPAssword { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        public IWebElement btnLogin { get; set; }



     

        public void Login(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPAssword.SendKeys(password);
            
        }

      

        public HomePage ClickLogin()
        {
            btnLogin.Submit();
            return GetPageInstance<HomePage>();
        }

      
    }
}
