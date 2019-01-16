using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a sentence: ");
            string sen, rev;
            sen = Console.ReadLine();
            char[] ch = sen.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = sen.Equals(rev, StringComparison.OrdinalIgnoreCase);

            if (b == true)
            {
                Console.WriteLine(sen + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(sen + " is not a Palindrome!");
            }
        }
    }
}
