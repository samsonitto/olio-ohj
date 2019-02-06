using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sorted = new List<string>();



            int disNimiLaskuri = File.ReadAllLines("nimet.txt").Distinct().Count();
            int riviLaskuri = File.ReadAllLines("nimet.txt").Count();

            Console.WriteLine("Löytyi {0} riviä ja {1} nimeä", riviLaskuri, disNimiLaskuri);

            foreach (string item in File.ReadAllLines("nimet.txt").Distinct())
            {
                int c = item.Distinct().Count();
                StringBuilder str = new StringBuilder(item + " " + c);
                
                Console.WriteLine(str);
                //Console.WriteLine("Nimi {0} esiintyy {1} kertaa",item,c);
                sorted.Add(str.ToString());
            }

            sorted.Sort();

            Console.WriteLine("\nLajiteltu lista: ");
            foreach(string nimi in sorted)
            {
                Console.WriteLine(nimi);
            }

           

            Console.WriteLine();
            string curFile = @"F:\Olio\KT08\T2\bin\Debug\nimet.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists!" : "File does not exist.!!!");
        }

        
    }
}
