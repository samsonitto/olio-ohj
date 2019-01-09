using System;

// namespace
namespace T1
{
    // class
    class Ohjelma
    {
        // method
        static void Main(string[] args)
        {

            while (true)
            { 
                Console.Write("Give a number > ");
                string input = Console.ReadLine();
                int number;
                bool tulos = int.TryParse(input, out number);

                if (tulos)
                { 
                    switch (number)
                    {
                        case 1: Console.WriteLine("One"); break;
                        case 2: Console.WriteLine("Two"); break;
                        case 3: Console.WriteLine("Three"); break;
                        default: Console.WriteLine("Some other number"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            }
        }
    }
}