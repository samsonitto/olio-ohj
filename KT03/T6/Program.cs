using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM a1 = new ATM();
            a1.ID = "A1";
            a1.Location = "Kuokkala";
            a1.FillATM();
            a1.Withdraw();
            a1.Withdraw();
            a1.Withdraw();
            a1.Withdraw();
            a1.Withdraw();
            a1.Withdraw();
            a1.PrintData();
            a1.History();

            if (a1.Cash < 2000)
            {
                a1.FillATM();
            }

            ATM a2 = new ATM();
            a2.ID = "A2";
            a2.Location = "Forum";
            a2.FillATM();
            a2.Withdraw();
            a2.Withdraw();
            a2.Withdraw();
            a2.Withdraw();
            a2.Withdraw();
            a2.Withdraw();
            a2.PrintData();
            a2.History();

            if (a2.Cash < 2000)
            {
                a2.FillATM();
            }
        }
    }
}
