using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest1
{
    public class Demo2Test
    {
        [Test]

        public void Alert()
        {
            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            // to get text writtern in alert
            string actualAlertText= driver.SwitchTo().Alert().Text;

            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }
    }
}
