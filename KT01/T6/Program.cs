using System;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give distance > ");
            string input = Console.ReadLine();
            double dis;
            double.TryParse(input, out dis);
            double gas = 7.02 / 100; // kulutus per 1 km
            double totalGas = dis * gas; // kokonaiskulutus
            double price = totalGas * 1.595; // kokonaishinta
            totalGas = Math.Round(totalGas, 2);
            price = Math.Round(price, 2);

            Console.WriteLine("Gasoline consume is " + totalGas + " liters and cost is " + price + " euros.");
        }
    }
}
