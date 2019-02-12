using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIMERKKI1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator laskin = new Calculator();
            Console.WriteLine(laskin.Add(5,5));
            Console.WriteLine(laskin.Multiply(5,5));
        }
    }
}
