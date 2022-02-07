using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpAutomation.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement txtboxUsername = driver.FindElement(By.Id("UserName"));

        IWebElement txtboxPassword = driver.FindElement(By.Id("Password"));

        IWebElement btnLogin = driver.FindElement(By.XPath(" //input[@value='Log in']"));

        public void EnterUserNameAndPassword(string username,string password)
        {
            txtboxUsername.SendKeys(username);
            txtboxPassword.SendKeys(password);
        }

        public void ClickLoginbtn()
        {
            btnLogin.Click();
        }
       
    }
}
