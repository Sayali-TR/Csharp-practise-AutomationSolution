using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest1
{
    public class Demo1SeleniumAdvance
    {
        [Test]
        public void PhpAdmin()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            /*Console.WriteLine(driver.WindowHandles[0]);
            Console.WriteLine(driver.WindowHandles[1]); */

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin@123");
            driver.FindElement(By.Id("input_go")).Click();
            Console.WriteLine(driver.Title);
            driver.Quit();

        }

        [Test]
        

        public void CityBank()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();
            driver.FindElement(By.XPath("//a[@title='Banking']")).Click();
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
           driver.FindElement(By.LinkText("Branch/ATM")).Click();
            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();
            driver.Quit();






        }

    }
}
