using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EjemploUnit01
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.ebay.com");
            IWebElement elementSearch = driver.FindElement(By.Name("_nkw"));
            elementSearch.SendKeys("shoes");
            IWebElement elementSearchButton = driver.FindElement(By.Id("gh-btn"));
            elementSearchButton.Click();
            IWebElement elementBrandCheck = driver.FindElement(By.Id("e1-51"));
            elementBrandCheck.Click();
            IWebElement elementSizeCheck = driver.FindElement(By.Id("e1-29"));
            elementSizeCheck.Click();
        }
    }
}
