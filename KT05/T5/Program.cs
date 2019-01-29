using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack reppu = new Backpack();
            reppu.Name = "Nike";
            reppu.Price = 19.90;
            reppu.Year = 2015;
            Console.WriteLine(reppu.ToString());

            Console.WriteLine("==================================");

            Books digitaalitekniikka = new Books();
            digitaalitekniikka.Name = "Digitaalitekniikka";
            digitaalitekniikka.Price = 39.90;
            digitaalitekniikka.Year = 2005;
            digitaalitekniikka.Author = "Matti Mieskolainen";
            digitaalitekniikka.Genre = "njaa";
            Console.WriteLine(digitaalitekniikka.ToString());

            Console.WriteLine("==================================");

            eBooks lifeofpi = new eBooks();
            lifeofpi.Name = "Life Of Pi";
            lifeofpi.Price = 9.90;
            lifeofpi.Year = 2015;
            lifeofpi.Author = "unknown";
            lifeofpi.Genre = "fiction";
            lifeofpi.Platform = "iBooks in iOS12";
            Console.WriteLine(lifeofpi.ToString());

            Console.WriteLine("==================================");

            MathBooks matematiikka1 = new MathBooks();
            matematiikka1.Name = "Matematiikka 1";
            matematiikka1.Price = 19.90;
            matematiikka1.Year = 2015;
            matematiikka1.Author = "Sirpa Alestalo";
            matematiikka1.Genre = "Mathemathics";
            matematiikka1.Class = "University of Applied Sciences";
            Console.WriteLine(matematiikka1.ToString());

            Console.WriteLine("==================================");

            ComputingDevices iPad = new ComputingDevices();
            iPad.Name = "Samsonin iPad";
            iPad.Price = 599.90;
            iPad.Year = 2015;
            iPad.OS = "IOS12";
            iPad.Manufacturer = "Apple";
            iPad.Camera = true;
            Console.WriteLine(iPad.ToString());

            Console.WriteLine("==================================");

            Smartphones iPhone = new Smartphones();
            iPhone.Name = "Samsonin iPhone";
            iPhone.Price = 999.90;
            iPhone.Year = 2017;
            iPhone.OS = "IOS12";
            iPhone.Manufacturer = "Apple";
            iPhone.Camera = true;
            iPhone.PortraitMode = false;
            Console.WriteLine(iPhone.ToString());

            Console.WriteLine("==================================");

            Computers macBook = new Computers();
            macBook.Name = "Samsonin MacBook";
            macBook.Price = 1999.90;
            macBook.Year = 2017;
            macBook.OS = "OS X Majave";
            macBook.Manufacturer = "Apple";
            macBook.Camera = true;
            macBook.SSD = true;
            macBook.Type = "laptop";
            Console.WriteLine(macBook.ToString());

            Console.WriteLine("==================================");
        }
    }

    public class Backpack
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }

        public Backpack()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", price: " + Price + ", year: " + Year;
        }
    }

    public class Books : Backpack
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public Books()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", author: " + Author + ", genre: " + Genre;
        }
    }

    public class ComputingDevices : Backpack
    {
        public string OS { get; set; }
        public string Manufacturer { get; set; }
        public bool Camera { get; set; }

        public ComputingDevices()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", OS: " + OS + ", manufacturer: " + Manufacturer + ", camera: " + Camera;
        }
    }

    public class eBooks : Books
    {
        public string Platform { get; set; }

        public eBooks()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", platform: " + Platform;
        }
    }

    public class MathBooks : Books
    {
        public string Class { get; set; }

        public MathBooks()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", class: " + Class;
        }
    }

    public class Smartphones : ComputingDevices
    {
        public bool PortraitMode { get; set; }

        public Smartphones()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Portrait mode: " + PortraitMode;
        }
    }

    public class Computers : ComputingDevices
    {
        public string Type { get; set; }
        public bool SSD { get; set; }

        public Computers()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", type: " + Type + ", SSD: " + SSD;
        }
    }

}
