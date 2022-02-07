using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpAutomation
{
    public class CustomControl:DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement combobox = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            combobox.Clear();
            combobox.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

        public static void EnterText(IWebElement webelement, string value)
        {
            webelement.SendKeys(value);
        }

        public static void Click(IWebElement webelement)
        {
            webelement.Click();
        }

        public static void SelectByText(IWebElement webelement,string text)
        {
            SelectElement select = new SelectElement(webelement);
            //    System.Threading.Thread.Sleep(5000);
                select.SelectByText(text);
        }
    }
}
