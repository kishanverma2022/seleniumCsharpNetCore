using OpenQA.Selenium;
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
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text(),'{value}']")).Click();
        }
    }
}
