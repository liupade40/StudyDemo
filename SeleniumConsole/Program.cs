using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); //(Chrome浏览器)
            driver.Manage().Window.Maximize();
            driver.Url = "http://baidu.com";
            var element= driver.FindElement(By.Id("kw"));
            element.SendKeys("你好啊");
            var element2 = driver.FindElement(By.Id("su"));
            element2.Submit();
            WebDriverWait explicitWait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            var element3 = explicitWait.Until(d => d.FindElement(By.XPath("//*[@id=\"1\"]/h3/a")));
            
            //*[@id="1"]/h3/a
            element3.Click();
            //Assert.IsTrue(text.Contains("invalid username or password"));
            Console.WriteLine(driver.Title);
            Console.ReadKey();
            driver.Quit();
        }
    }
}
