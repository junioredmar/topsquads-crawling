using OpenQA.Selenium;
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
    public class Groceries : IDisposable
    {
        ChromeDriver driver;

        public Groceries()
        {
            driver = new ChromeDriver("C:\\chromedriver_win32");
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void Login()
        {
            driver.Url = "";
            Console.WriteLine("Faça login e pressione Enter...");
            Console.ReadLine();
        }

        public void FindSlot()
        {
            var radios = driver.FindElementsByClassName("group-selector--list-item");
            foreach (var radio in radios)
            {
                ClickAtElement(radio);
                Thread.Sleep(2000);
                IterateOverDates();
            }
        }

        private void IterateOverDates()
        {
            var elements = driver.FindElementsByClassName("slot-selector--week-tabheader");
            foreach (var element in elements)
            {
                ClickAtElement(element);
                var grid = driver.FindElementByClassName("slot-grid");
                try
                {
                    var slotsAvailable = grid.FindElement(By.ClassName("book-a-slot--info-message"));
                    if (slotsAvailable.Text.ToLower() == "No slots available! Try another day".ToLower())
                    {
                        continue;
                    }
                    else
                    {
                        Beep();
                    }
                }
                catch (NoSuchElementException)
                {
                    Beep();
                }
            }
        }

        private void Beep()
        {
            Console.Beep(3000, 2000);

            //var gridItems = driver.FindElementsByClassName("slot-grid--item available");
            //foreach (var gridItem in gridItems)
            //{
            //    var buttons = gridItem.FindElements(By.ClassName("available-slot--button"));
            //    foreach (var button in buttons)
            //    {
            //        ClickAtElement(button);
            //        var checkout = driver.FindElementByClassName("mini-trolley__checkout");
            //        var checkoutClass = checkout.GetAttribute("class");
            //        if (!checkoutClass.Contains("button-disabled"))
            //        {
            //            ClickAtElement(checkout);
            //            Console.WriteLine("Checkout clicado!");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Checkout disabilitado");
            //        }
            //    }
            //}

            Console.WriteLine("Pressione Enter para continuar");
            Console.ReadLine();
            Console.WriteLine("continuando...");
        }

        private static void ClickAtElement(OpenQA.Selenium.IWebElement element)
        {
            bool clicked = false;
            do
            {
                try
                {
                    if (!element.Displayed)
                    {
                        Thread.Sleep(1000);
                    }
                    element.Click();
                    clicked = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"COULDNT CLICK: {e.Message}");
                }
            } while (!clicked);

            Thread.Sleep(1000);
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
