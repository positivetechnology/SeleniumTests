using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://gs.turn2us.org.uk");
            Console.WriteLine(driver.Title);

            IWebElement element = driver.FindElement(By.Id("Postcode"));
            element.SendKeys("TW12AG");

            element = driver.FindElement(By.Id("IsMale"));
            element.Click();

            element = driver.FindElement(By.Id("Age"));
            element.SendKeys("21");

            element = driver.FindElement(By.Id("searchButton"));

            element.Submit();



            element = driver.FindElement(By.ClassName("resultheader"));
            Console.WriteLine(element.Text);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
