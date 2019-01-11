using System;


namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;

            while (true)
            {
                Console.Write("Give a number: ");
                string input = Console.ReadLine();
                int num;
                int.TryParse(input, out num);
                

                sum += num;

                if (num == 0)
                {
                    //for ( int j = 0; j < num.Length ; j++ )
                    Console.WriteLine("Summa on: " + sum);
                    break;
                }
            }
        }
    }
}
