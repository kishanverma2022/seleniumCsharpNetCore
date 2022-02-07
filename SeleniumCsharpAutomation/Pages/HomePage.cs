using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpAutomation.Pages
{
  public class HomePage: DriverHelper
    {
        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));

        IWebElement lnkLogoff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin()
        {
            lnkLogin.Click();
        }

        // ------------OR------------------

        public void ClickLogin1() => lnkLogin.Click();

        public bool IslogOffExist()
        {
          return  lnkLogoff.Displayed;
        }
    }
}
