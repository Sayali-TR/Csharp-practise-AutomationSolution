using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest1
{
    public class UploadTest
    {
        [Test]
        // upload documents
        public void UploadTestCase()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ilovepdf.com/pdf_to_word";
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Users\6124594\OneDrive - Thomson Reuters Incorporated\Desktop\Single pg Conso.pdf");
        }

        [Test]
        public void MouseHover()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.myntra.com/";

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='Men']"))).Perform();
            driver.FindElement(By.XPath("//a[text()='T-Shirts']")).Click();

        }


        [Test]
        public void MouseHover2()
        {
            IWebDriver driver =new ChromeDriver();
            driver.Url = "https://futureskillsprime.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();
            action.MoveToElement(driver.FindElement(By.XPath("//a[text()='FutureSkills Prime']"))).Perform();
            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();
            driver.Quit();



        }

        [Test]
        // Keyboad activities
        public void KeyboadActivities()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Actions action =new Actions(driver);

           action.KeyDown(Keys.Shift).SendKeys("Hello World").Perform();

        }
        [Test]

        // CSS selector
        public void CssSelector()
        {
            /* css selector
            1. by id : #id
            2. by classname: .ClassName
            3. by tagname : tagname[attribute='value'] */

            IWebDriver driver=new ChromeDriver();
            driver.Url = "https://demo.openemr.io/openemr/interface/login/login.php?site=default";
            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("admin123");
            driver.FindElement(By.CssSelector("button[id='login-button']")).Click();
        }
    }
}
