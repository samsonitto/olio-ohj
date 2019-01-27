using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car corsa = new Car();
            corsa.Name = "Opel";
            corsa.Model = "Corsa";
            corsa.ModelYear = 1996;
            corsa.Color = "White";
            corsa.DoorCount = 2;
            Console.WriteLine("Car info");
            Console.WriteLine(corsa.ToString());

            Console.WriteLine("============================================================================================================");

            Boat pekka = new Boat();
            pekka.Name = "Pekka";
            pekka.Model = "S900";
            pekka.ModelYear = 1983;
            pekka.Color = "Black";
            pekka.SeatCount = 3;
            pekka.BoatType = "Rowboat";
            Console.WriteLine("Boat info");
            Console.WriteLine(pekka.ToString());

            Console.WriteLine("============================================================================================================");

            Bike trek = new Bike();
            trek.Name = "Trek";
            trek.Model = "Mountain bike";
            trek.ModelYear = 2015;
            trek.Color = "Red";
            trek.GearWheels = true;
            trek.GearName = "Shimano";
            Console.WriteLine("Bike info");
            Console.WriteLine(trek.ToString());

        }
    }

    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {

        }

        public override string ToString()
        {
            return "- Name: " + Name + ", Model: " + Model + ", Year: " + ModelYear + ", Color: " + Color;
        }
    }

    public class Car : Vehicle
    {
        public int DoorCount { get; set; }

        public Car()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Door count: " + DoorCount;
        }
    }

    public class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", Seat count: " + SeatCount + ", Boat type: " + BoatType;
        }
    }

    public class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", GearWheels: " + GearWheels + ", Gear name: " + GearName;
        }

    }
}
