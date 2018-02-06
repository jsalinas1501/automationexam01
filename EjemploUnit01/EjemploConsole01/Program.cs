using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConsole01
{
    public class Program
    {
        //IWebDriver driver = new ChromeDriver();
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {            
        }
        
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.ebay.com");
        }

        [Test]
        public void ExecuteTest()
        {
            ElementEvents.EnterText(driver, "_nkw", "shoes", "Name");
            ElementEvents.Click(driver, "gh-btn", "Id");
            ElementEvents.Click(driver, "e1-51", "Id");
            ElementEvents.Click(driver, "e1-29", "Id");
            IWebElement elementNumberResult = driver.FindElement(By.ClassName("rcnt"));
            Console.WriteLine("Number of results: " + elementNumberResult.Text);
            Console.WriteLine("*********************************************************************");

            ElementEvents.Click(driver, "//*[@id='DashSortByContainer']/ul[1]", "XPath");
            ElementEvents.Click(driver, "//*[@id='SortMenu']/li[3]", "XPath");
            IWebElement[] allProductsPriceAscendant = driver.FindElements(By.XPath("//*[@id='GalleryViewInner']")).ToArray();
            string[] stringSeparators = new string[] { "\r\n" };
            string[] allProductsPriceAscendantFinal = allProductsPriceAscendant.FirstOrDefault().Text.Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(allProductsPriceAscendantFinal[i]);
            }
            Console.WriteLine("*********************************************************************");


            ElementEvents.Click(driver, "//*[@id='DashSortByContainer']/ul[1]", "XPath");
            ElementEvents.Click(driver, "//*[@id='SortMenu']/li[4]", "XPath");
            IWebElement[] allProductsPriceDescendant = driver.FindElements(By.XPath("//*[@id='GalleryViewInner']")).ToArray();
            string[] allProductsPriceDescendantFinal = allProductsPriceDescendant.FirstOrDefault().Text.Split(stringSeparators, StringSplitOptions.None);

            foreach (string product in allProductsPriceDescendantFinal)
            {
                Console.WriteLine(product);
                
            }
            Console.WriteLine("*********************************************************************");

        }

    }
}
