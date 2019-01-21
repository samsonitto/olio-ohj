using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace T2
{
    class WashingMachine
    {
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Program { get; set; }        


        public WashingMachine()
        {

        }

        public void SetPower()
        {
            Console.WriteLine("-------------");
            Console.WriteLine(Model);
            Console.WriteLine("-------------");
            Console.Write("Turn the machine on? y/n > ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Power = true;
            }

            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Power = false;
            }
        }

        public void SetProg()
        {
            if (Power == true)
            {

                Console.Write("Set washing program: 1-4 > ");
                Program = int.Parse(Console.ReadLine());

                if (Program == 1)
                {
                    Console.WriteLine("Handwash program.");
                    Console.Write("Washing");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(2000);
                    }
                    Console.WriteLine();
                }
                if (Program == 2)
                {
                    Console.WriteLine("40 C program.");
                    Console.Write("Washing");

                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(2000);
                    }
                    Console.WriteLine();
                }
                if (Program == 3)
                {
                    Console.WriteLine("60 C program.");
                    Console.Write("Washing");

                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(2000);
                    }
                    Console.WriteLine();
                }
                if (Program == 4)
                {
                    Console.WriteLine("Cleaning program.");
                    Console.Write("Cleaning the washing machine");

                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(2000);
                    }
                    Console.WriteLine();
                }
                else if (Program>4)
                {
                    Console.WriteLine("Wrong program, try again!");
                }
            }
            else
            {
                Console.WriteLine("The machine is off!");
            }
        }
        

        public void PrintData()
        {
            Console.WriteLine("Washing machine data: ");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("On/Off: {0}", Power);
            Console.WriteLine("Program used: {0}", Program);
        }
    }
}
