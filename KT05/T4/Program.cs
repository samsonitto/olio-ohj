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
            Kirjahylly bookShelf = new Kirjahylly();
            bookShelf.Name = "Samsonin kirjahylly";
            bookShelf.UsedFor = "Tavaroiden sälyttämiseen";
            bookShelf.Year = 2010;
            bookShelf.Price = 100;
            Console.WriteLine(bookShelf.ToString());

            Console.WriteLine("======================================================");

            Books kirja1 = new Books();
            kirja1.Name = "C# for dummies";
            kirja1.UsedFor = "reading";
            kirja1.Year = 2015;
            kirja1.Price = 50;
            kirja1.Author = "Matti Mieskolainen";
            Console.WriteLine(kirja1.ToString());

            Console.WriteLine("======================================================");

            Games fifa19 = new Games();
            fifa19.Name = "FIFA 19";
            fifa19.UsedFor = "Gaming";
            fifa19.Year = 2018;
            fifa19.Price = 59;
            fifa19.Platform = "PS4";
            fifa19.Genre = "sports simulator";
            Console.WriteLine(fifa19.ToString());

            Console.WriteLine("======================================================");

            Phones nokia = new Phones();
            nokia.Name = "Nokia";
            nokia.UsedFor = "Calling and texting";
            nokia.Year = 2000;
            nokia.Price = 100;
            nokia.Type = "flip phone";
            nokia.Model = "S10";
            Console.WriteLine(nokia.ToString());

            Console.WriteLine("======================================================");

            SmartPhones iphoneX = new SmartPhones();
            iphoneX.Name = "iPhone";
            iphoneX.Model = "X";
            iphoneX.UsedFor = "Life";
            iphoneX.Year = 2017;
            iphoneX.Price = 1100;
            iphoneX.Type = "smartphone";
            iphoneX.OS = "iOS12";
            iphoneX.Memory = 256;
            
            Console.WriteLine(iphoneX.ToString());

            Console.WriteLine("======================================================");
        }
    }

    public class Kirjahylly
    {
        public string Name { get; set; }
        public string UsedFor { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Kirjahylly()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", used for: " + UsedFor + ", year: " + Year + ", price: " + Price + "$";
        }


    }

    public class Books : Kirjahylly
    {
        public string Author { get; set; }

        public Books()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", author: " + Author;
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
        

        public Phones()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Type: " + Type + ", model: " + Model;
        }
    }

    public class SmartPhones : Phones
    {
        public string OS { get; set; }
        public int Memory { get; set; }

        public SmartPhones()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", operating system: " + OS + ", memory: " + Memory + "Gb";
        }
    }
}
