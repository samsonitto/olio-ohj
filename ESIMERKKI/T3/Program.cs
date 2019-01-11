using System;


namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna numero 1 > ");
            string input1 = Console.ReadLine();
            Console.Write("Anna numero 2 > ");
            string input2 = Console.ReadLine();
            Console.Write("Anna numero 3 > ");
            string input3 = Console.ReadLine();

            float a, b, c;

            float.TryParse(input1, out a);
            float.TryParse(input2, out b);
            float.TryParse(input3, out c);

            float summa = a+b+c;
            float keskiarvo = summa / 3;

            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);
        }
    }
}
