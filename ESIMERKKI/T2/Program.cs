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

            Console.Write("Max points > ");
            string input = Console.ReadLine();
            int points;
            int.TryParse(input, out points);

            if (points < 2)
            {
                Console.WriteLine("Your grade is 0 :(");
            }
            else if (points < 4 && points > 1)
            {
                Console.WriteLine("Your grade is 1 :/");
            }
            else if (points < 6 && points > 3)
            {
                Console.WriteLine("Your grade is 2 :|");
            }
            else if (points < 8 && points > 5)
            {
                Console.WriteLine("Your grade is 3 :|");
            }
            else if (points < 10 && points > 7)
            {
                Console.WriteLine("Your grade is 4 :)");
            }
            else if (points > 9)
            {
                Console.WriteLine("Your grade is 5 :D");
            }
            else
            {
                Console.WriteLine("Wrong point total");
            }
            
        }
    }
}