using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace My_Store
{
   
    class Program
    {
       /* //Create the reference for our browser - globalna varijabla
        IWebDriver driver = new ChromeDriver(); */

        static void Main(string[] args)
        {
            // Automation of Smoke TC-1, TC-2 and TC-3

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            IWebElement element1 = driver.FindElement(By.Name("email"));
            element1.SendKeys("elvedinbrkan@gmail.com");
            IWebElement element2 = driver.FindElement(By.Name("passwd"));
            element2.SendKeys("Kupovina123!");
            driver.FindElement(By.Name("SubmitLogin")).Click();
            IWebElement element3 = driver.FindElement(By.Name("search_query"));
            element3.SendKeys("Faded Short Sleeve T-shirts");
            driver.FindElement(By.Name("submit_search")).Click();
            IWebElement element4 = driver.FindElement(By.ClassName("logout"));
            driver.FindElement(By.ClassName("logout")).Click();



        }


        /*
        [SetUp] //NUnit atribut
        public void Initialize()  //Prva metoda za izvrsavanje - start 
        {
            //Navigate to Google page
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test] //NUnit atribut
        public void ExecuteTest() //Druga metoda za izvrsavanje - operacije
        {
            //Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operations
            element.SendKeys("automationpractice");
        }

        [TearDown] //NUnit atribut
        public void CleanUp() //Treca ili zadnja metoda za izvrsavanje - zatvaranje
        {
            //Close the test/driver instance
            driver.Close();
        }
        */

    }
}
