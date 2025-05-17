using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests
{
    internal class Tests
    {
        [Test]
        public void Test1_field()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            // IMPORTANT! Must add path to own chrome driver location!
            IWebDriver driver = new ChromeDriver(@"C:\Users\rkime\OneDrive\Dators\", options);
            driver.Url = "https://ebay.com";
            driver.FindElement(By.Id("gh-ac"));
        }

        public void Test2_search()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            // IMPORTANT! Must add path to own chrome driver location!
            IWebDriver driver = new ChromeDriver(@"C:\Users\rkime\OneDrive\Dators\", options);
            driver.Url = "https://ebay.com";
            driver.FindElement(By.Id("gh-search-btn"));
        }
    }
}
