using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Security.Claims;

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
            driver.FindElement(By.Name("CompanyName")).SendKeys("TR");
            SelectElement s = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));

            s.SelectByText("United Kingdom");


            driver.FindElement(By.Name("CompanyEmployees")).SendKeys("101-200 Employees");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();


            String actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;
            Console.Write(actualError );










        }

    }
}
