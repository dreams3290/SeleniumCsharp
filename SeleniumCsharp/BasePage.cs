using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumCsharp
{
    public class BasePage
    {
        IWebDriver driver = new FirefoxDriver();
        //public static void Main(string[] args)
        //{ }

        /*  [SetUp]
          public void initialize()
          {
              driver = new FirefoxDriver();
          }*/

        //[TearDown]
        public void endTest()
        {
            driver.Close();
        }


        public void URL(String url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();

        }
        public void findTheElement(String XPATH)
        {
            driver.FindElement(By.XPath(XPATH));
        }
        public void clickTheElement(String XPATH)
        {
            driver.FindElement(By.XPath(XPATH)).Click();
        }
        public void clearTheElement(String XPATH)
        {
            driver.FindElement(By.XPath(XPATH)).Clear();
        }
        public void writeHost(String text)
        {
            Console.WriteLine(text);
        }
        public void getTextOfTheElement(String XPATH, String value)
        {
            value = driver.FindElement(By.XPath(XPATH)).Text;
            writeHost(value);
        }


    }
}
