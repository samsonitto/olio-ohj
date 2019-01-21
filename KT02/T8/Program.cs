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
            char[] ch = sen.ToCharArray(); // muuttaa lauseen kirjaimiksi ja tallentaa ch taulukkoon

            Array.Reverse(ch); // k‰‰ntt‰‰ taulukkoon tallennetut kirjaimet toiseen suuntaan
            rev = new string(ch); // luo uuden merkkijonon k‰‰nnetyst‰ lauseesta

            bool b = sen.Equals(rev, StringComparison.OrdinalIgnoreCase); // verttaa merkkijonot kesken‰‰n

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
