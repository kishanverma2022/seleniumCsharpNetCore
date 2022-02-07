using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCsharpAutomation.Pages;
using System;
using System.Threading;

namespace SeleniumCsharpAutomation
{
    [TestFixture]
    public class Tests: DriverHelper
    {
     
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            driver = new ChromeDriver();
        }

        //[Test]
        //public void Test1()
        //{
        //    driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        //    System.Threading.Thread.Sleep(3000);
        //    CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")),"Tomato");
        //    CustomControl.Click(driver.FindElement(By.XPath("//Input[@class='ctl00$ContentPlaceHolder1$ChildMeal1']")));
        //    Assert.Pass();
        //    driver.Quit();
        //}

        //[Test]
        //public void Test2() 
        //{

        //    driver.Navigate().GoToUrl("https://www.spicejet.com/");
        //     driver.FindElement(By.LinkText("round trip")).Click();
        //    bool sel= driver.FindElement(By.LinkText("round trip")).Selected;
        //    if (sel)
        //    {
        //        Console.WriteLine("Test Pass");
        //        Assert.Pass();
        //    }
        //    else
        //        Console.WriteLine("Fail");

        //}

        //[Test]
        //public void AjaxControlText()
        //{
        //    driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        //    driver.FindElement(By.XPath("//Input[@class='ctl00$ContentPlaceHolder1$ChildMeal1']")).Click();
        //    //driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("to");
        //    //string resultbox=driver.FindElement(By.Id("ContentPlaceHolder1_Meal-dropmenu")).Text;
        //    //Console.WriteLine(resultbox);
        //    driver.Quit();


        //}

        //[Test]
        //public void ddrDownProgram()
        //{
        //    driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        //    //SelectElement select = new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")));
        //    System.Threading.Thread.Sleep(5000);
        //    CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Broccoli");
        //    // select.SelectByText("Broccoli");
        //    System.Threading.Thread.Sleep(5000);
        //    driver.Quit();

        //}
            //}
            //[Test]
            //public void ddrDownProgram()
            //{
            //    driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            //    System.Threading.Thread.Sleep(3000);
            //    driver.FindElement(By.XPath("//div[contains(text(),'Celery')]")).Click();

            //    System.Threading.Thread.Sleep(5000);
            //    driver.Quit();
            //}

          //  [Test]
        //public void comboboxProgram()
        //{
        //    driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
        //    System.Threading.Thread.Sleep(3000);
            
        //    CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
        //    System.Threading.Thread.Sleep(5000);
        //    Console.WriteLine("Testing Github CheckIn");
        //    driver.Quit();
        //}
        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homepage = new HomePage();
            homepage.ClickLogin1();
            Thread.Sleep(5000);
            LoginPage loginpage = new LoginPage();
            loginpage.EnterUserNameAndPassword("admin", "password");
            Thread.Sleep(3000);
            loginpage.ClickLoginbtn();
            Thread.Sleep(3000);
            Assert.That(homepage.IslogOffExist, Is.True,"LogOff button is not avaliable on the page");
            driver.Quit();


        }

    }
}