using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirePlace harvia = new FirePlace();
            harvia.Name = "Harvia";
            harvia.Power = true;
            harvia.Loyly();
            harvia.Loyly();
            harvia.Loyly();
            harvia.Loyly();
            harvia.Loyly();


            harvia.Wait();


            harvia.PrintData();

            Console.WriteLine("-----------------------------");

            FirePlace asd = new FirePlace();
            asd.Name = "Random kiuas";
            asd.Power = false;

            asd.PrintData();
        }
    }
}
