using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle corsa = new Vehicle();
            corsa.Name = "Opel Corsa";
            corsa.SetTyres();
            corsa.Accelerate();
            corsa.Accelerate();
            corsa.Accelerate();
            corsa.Accelerate();
            corsa.Accelerate();
            corsa.Accelerate();
            corsa.Brake();
            corsa.PrintData();
            Console.WriteLine(corsa.ToString());



        }
    }
}
