using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter info = new StreamWriter("info.txt");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a text line (enter ends) : ");
                string nimi = Console.ReadLine();
                info.WriteLine(nimi);
            }
            info.Close();

            string text = File.ReadAllText("info.txt");
            Console.WriteLine("Contents of info.txt: ");
            Console.WriteLine(text);
        }
    }
}
