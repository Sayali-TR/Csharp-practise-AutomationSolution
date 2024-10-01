using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask2
{
    public class Saleforce
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);
            

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

           // driver.FindElement(By.Id("rejectInvite")).Click();

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            
            driver.FindElement(By.Name("UserTitle")).SendKeys("IT Manager");



        }

    }
}
