using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo2FBSignUp
    {
        static void Main(string[]args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(45);

            driver.Url = "https://www.facebook.com/";
            

            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
            Thread.Sleep(1000);//not recommened
            driver.FindElement(By.Name("firstname")).SendKeys("Alex");
            driver.FindElement(By.Name("lastname")).SendKeys("Paul");
            driver.FindElement(By.Name("reg_email__")).SendKeys("abc@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("Alex@321");
            //Drowdown 
            SelectElement day = new SelectElement(driver.FindElement(By.Id("day")));
            day.SelectByText("17");
            //driver.FindElement(By.Id("day")).SendKeys("23");
            driver.FindElement(By.Id("month")).SendKeys("Dec");
            driver.FindElement(By.Id("year")).SendKeys("1992");
            driver.FindElement(By.XPath("//input[@value='2']")).Click();
            driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();
            


        }
    }
}
