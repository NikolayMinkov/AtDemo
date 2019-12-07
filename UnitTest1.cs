using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace atDemo
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        
    
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            
        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
        [TestMethod]
        public void validname()
        {
            driver.Navigate().GoToUrl("https://www.abv.bg/");
            driver.Manage().Window.Size = new System.Drawing.Size(1073, 1040);
            driver.FindElement(By.Id("username")).SendKeys("valid_email");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("123456789");
            driver.FindElement(By.Id("loginBut")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.AreEqual(driver.FindElement(By.Id("form.errors")).Text,"Грешен потребител / парола.");
        }
       
        
    }
}
