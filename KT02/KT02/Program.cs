using System;


namespace KT02
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            int[] numbers = new int[5];

            

            for (int i=0; i < 5 ; i++)
                {
                    Console.Write("Give a number > ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

            Console.Write("Numbers are: ");

            for (int j = 4; j>=0; j--)
            {
                Console.Write(numbers[j]);
                if (j>0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            }
        }
    }
}
