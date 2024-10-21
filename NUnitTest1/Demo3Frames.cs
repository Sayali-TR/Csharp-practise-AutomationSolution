using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest1
{
    public class Demo3Frames
    {
        [Test]
        public void Frames()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']"))); //to switch another frame
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("John123");
            driver.FindElement(By.LinkText("CONTINUE")).Click();
            driver.FindElement(By.Id("fldPasswordDispId")).SendKeys("kkkk");
            driver.FindElement(By.XPath("(//input[@type='checkbox'])[3]")).Click();
            driver.FindElement(By.PartialLinkText("LOGIN")).Click();




            driver.SwitchTo().DefaultContent(); //to switch main frame





        }
    }
}
