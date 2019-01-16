using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car datsun = new Car();
            datsun.Model = "Datsuni";
            datsun.Color = "red";
            Car.SomeProperty = 10;

            datsun.PrintData();
            Console.WriteLine("******************************");

            datsun.Accelerate();
            datsun.PrintData();
            Console.WriteLine("******************************");

            Car Audi = new Car("Audimies", "musta", 2.0);
            Car.SomeProperty = 200;
            Audi.PrintData();
            Console.WriteLine("******************************");
            datsun.PrintData();
        }
    }
}
