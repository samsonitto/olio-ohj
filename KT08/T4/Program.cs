using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            double numD;
            int numInt;

            List<int> iList = new List<int>();
            List<double> dList = new List<double>();

            StreamWriter i = new StreamWriter("T2Integers.txt");
            StreamWriter d = new StreamWriter("T2Doubles.txt");

            
            while(true)
            {
                Console.Write("Give a number (enter ends) > ");
                value = Console.ReadLine();
                
                if (int.TryParse(value, out numInt))
                {
                    iList.Add(numInt);
                }
                else if (value == "")
                {
                    break;
                }
                else 
                {
                    Double.TryParse(value, out numD);
                    dList.Add(numD);
                }
                
            }

            foreach(double item in dList)
            {
                d.WriteLine(item);
            }
            d.Close();

            foreach (int item in iList)
            {
                i.WriteLine(item);
            }
            i.Close();

            Console.WriteLine("Contents of T2Integers.txt:");
            foreach (string item in File.ReadAllLines("T2Integers.txt"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Contents of T2Doubles.txt:");
            foreach (string item in File.ReadAllLines("T2Doubles.txt"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
