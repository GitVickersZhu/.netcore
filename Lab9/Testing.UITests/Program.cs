using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testing.UITests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start UI tests");

            var driver = new ChromeDriver(@"C:\"); //Open bew browser
            driver.Navigate().GoToUrl("http://www.google.com"); //navigate to page
            var query = driver.FindElement(By.Name("q"));
            query.SendKeys("Hello Selenium!");
            query.Submit();

            Console.WriteLine("UI tests ended");

        }
    }
}
