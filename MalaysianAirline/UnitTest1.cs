using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Net;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Extensions;

namespace MalaysianAirline
{
    public class Tests
    {
        [Test]
        public void Airline()
        {
            // To avoid any notification
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();
            
            driver.ExecuteJavaScript("document.querySelector(\"input[name='dateDeparture']\").value='21 Oct 2024'\r\n");





        }


    }
}