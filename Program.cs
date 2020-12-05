using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace webscraping_tutoriol
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Projects\webscraping_tutoriol\bin\Debug\netcoreapp3.1");
            driver.Url = "https://www.google.com";

            Console.WriteLine(driver.Title);
            IWebElement textbox = driver.FindElement(By.Name("q"));
            textbox.SendKeys("cat Pictures");

            textbox.Submit();
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
