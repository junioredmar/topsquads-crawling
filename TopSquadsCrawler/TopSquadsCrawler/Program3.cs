using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TopSquadsCrawler
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Groceries..");
            using (var grocery = new Groceries())
            {
                grocery.Login();
                do
                {
                    Console.WriteLine("Buscando slots...");
                    grocery.FindSlot();
                    Console.WriteLine("Nao encontrou!");
                    grocery.RefreshPage();
                    Thread.Sleep(2000);
                } while (true);
            }

            
        }
    }
}
