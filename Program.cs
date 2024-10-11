using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_11_2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat (DateTime):
            var ido = DateTime.Now;
            Console.WriteLine("A ponots idő: {0}", ido);

            if (DateTime.Now.Hour < 10)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (DateTime.Now.Hour > 10 || DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Kellemes délelőttöt!");
            }
            else if (DateTime.Now.Hour > 12 || DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Kellemes délutánt!");
            }
            else if (DateTime.Now.Hour > 18)
            {
                Console.WriteLine("Jó éjszakát");
            }
        }
    }
}
