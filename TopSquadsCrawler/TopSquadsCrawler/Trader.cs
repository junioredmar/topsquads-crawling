using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TopSquadsCrawler
{
    public class Trader : IDisposable
    {
        ChromeDriver driver;

        public Trader()
        {
            driver = new ChromeDriver("C:\\chromedriver_win32");
        }

        public void Login()
        {
            driver.Url = "";
            Console.WriteLine("Faça login e pressione Enter...");
            Console.ReadLine();
        }
        
        public void ReList()
        {
            ClickAtClass("icon-store");
            ClickAtClass("icon-transfer");
            ClickAtClass("ut-tile-transfer-list");
            //ClickAtButton("Clear Sold", "call-to-action");
            ClickAtButton("Re-list All", "call-to-action");

            ClickAtButton("Yes", "btn-text");
        }

        private void ClickAtButton(string buttonText, string className)
        {
            var elements = driver.FindElementsByClassName(className);
            var element = elements.FirstOrDefault(a => a.Text.ToLower() == buttonText.ToLower());
            if (element != null)
            {
                var actions = new Actions(driver);
                actions.MoveToElement(element).Perform();
                Thread.Sleep(1000);
                ClickAtElement(element);
            }
        }

        private void ClickAtClass(string className)
        {
            var element = driver.FindElementByClassName(className);
            ClickAtElement(element);
            Console.WriteLine($"Clicked {className}");
        }

        private static void ClickAtElement(OpenQA.Selenium.IWebElement element)
        {
            do
            {
                Thread.Sleep(1000);
            } while (!element.Displayed);
            element.Click();
            Thread.Sleep(15000);
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
