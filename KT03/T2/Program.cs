using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WashingMachine siemens = new WashingMachine();
            siemens.Model = "Siemens";
            siemens.SetPower();
            siemens.SetProg();
            Console.WriteLine();
            siemens.PrintData();
            

            WashingMachine samsung = new WashingMachine();
            samsung.Model = "Samsung";
            samsung.SetPower();
            samsung.SetProg();
            Console.WriteLine();
            samsung.PrintData();

        }
    }
}
