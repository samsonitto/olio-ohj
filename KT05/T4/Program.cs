using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    public class Kirjahylly
    {
        public string Name { get; set; }
        public string UsedFor { get; set; }
        public int Year { get; set; }
        public string Material { get; set; }

        public Kirjahylly()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Used for: " + UsedFor + ", Year: " + Year + ", Material: " + Material;
        }


    }

    public class Games : Kirjahylly
    {
        public string Platform { get; set; }
        public string Genre { get; set; }

        public Games()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", genre: " + Genre + ", platform: " + Platform;
        }

    }

    public class Phones : Kirjahylly
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }

        public Phones()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Type: " + Type + ", model: " + Model + ", operating system: " + OS;
        }
    }

    public class CellPhones : Phones
    {

    }
}
