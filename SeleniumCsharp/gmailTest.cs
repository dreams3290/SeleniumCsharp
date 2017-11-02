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
    public class gmailTest:BasePage
    {
        public static void Main(string[] args)
        {
            gmailTest test = new gmailTest();
            test.gmailLogin();
        }

        [Test]
        public void gmailLogin()
        {
            URL("www.gmail.com");
        }
    }
}
