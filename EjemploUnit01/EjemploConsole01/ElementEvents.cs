using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConsole01
{
    class ElementEvents
    {


        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if(elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementType == "ClassName")
            {
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
        }

        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "ClassName")
            {
                driver.FindElement(By.ClassName(element)).Click();
            }
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }
        }

        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            
            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
            }
            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByValue(value);
            }
            if (elementType == "ClassName")
            {
                new SelectElement(driver.FindElement(By.ClassName(element))).SelectByValue(value);
            }
        }

    }
}
