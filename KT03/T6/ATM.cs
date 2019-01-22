using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace T6
{
    class ATM
    {
        public string ID { get; set; }
        public string Location { get; set; }
        public int Cash { get; set; }
        public static DateTime Now { get; }

        DateTime localDate = DateTime.Now;
        public ATM()
        {

        }

        int withdraw;
        int[] with = new int[10000];
        int counter = 0;
        public void FillATM()
        {
            Cash = 10000;
        }

        public void Withdraw()
        {
            Console.Write("Withdrawal amount: ");
            withdraw = int.Parse(Console.ReadLine());
            Cash = Cash - withdraw;
            counter++;
            with[counter] = withdraw;
        }
        public void History()
        {
            Console.WriteLine("Withrawal history");

            for (int i = 1; i<counter+1;i++ )
            {
                Console.Write(localDate);
                Console.Write(" Amount: ");
                Console.WriteLine(with[i]);
            }
        }

        public void PrintData()
        {
            Console.WriteLine("ID: {0} \nLocation: {1} \nCash left: {2}", ID, Location, Cash);
        }

        
    }
}
