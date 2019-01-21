using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class TV
    {
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Channel { get; set; }


        public TV()
        {

        }

        public void SetPower()
        {
            Console.WriteLine("-------------");
            Console.WriteLine(Model);
            Console.WriteLine("-------------");
            Console.Write("Turn on the TV? y/n > ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Power = true;
            }

            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Power = false;
            }
        }
        public void CheckPower()
        {
            if (Power == false)
            {
                Console.WriteLine("The TV is OFF!");
            }
        }
        public void ChUp()
        {
            if (Power == true)
            {
                Channel += 1;
            }
        }

        public void ChDown()
        {
            if (Power == true)
            {
                Channel -= 1;
            }
        }

        public void ChInput()
        {
            if (Power == true)
            {
                Console.Write("Input channel > ");
                Channel = int.Parse(Console.ReadLine());
            }
        }

        public void PrintData()
        {
            Console.WriteLine("The TV data: ");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("On/Off: {0}", Power);
            Console.WriteLine("Current channel: {0}", Channel);
        }
    }
}
