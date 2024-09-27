using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Program5
    {
        // to achieve cross browser testing
        public static void Main(string[] args)
        {
            /* string browser="chrome";
            IWebDriver obj;
            if (browser.Equals("edge"))
            {
                obj=new EdgeDriver();
            }

            else
            {
               obj=new ChromeDriver();

            }*/
            IWebDriver obj=new ChromeDriver();

           obj.Url = "https://www.facebook.com/";

             String title=obj.Title;
            Console.WriteLine(title);
            obj.Quit();

        }
    }
}
