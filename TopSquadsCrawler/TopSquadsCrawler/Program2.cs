using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TopSquadsCrawler
{
    class Program2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Auto trading..");
            using (var trader = new Trader())
            {
                trader.Login();
                do
                {
                    Console.WriteLine("Relistando...");
                    trader.ReList();
                    Console.WriteLine("Relistou!");
                    Thread.Sleep(4000000);
                } while (true);
            }
            
        }
    }
}
