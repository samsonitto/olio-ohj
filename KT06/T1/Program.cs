using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel nokia = new Wheel();
            nokia.Model = "Nokia";
            nokia.Type = "Hakkapeliitta";
            nokia.Size = "205R16";
            nokia.ToString();

            Vehicle porsche = new Vehicle();
            porsche.Name = "Porsche";
            porsche.VehicleModel = "911";
            Console.WriteLine("Created a new vehicle {0} model {1}", porsche.Name, porsche.VehicleModel);
            for (int i = 0; i < 4; i++)
            {
                porsche.wheels.Add(nokia);
                Console.WriteLine("Tyre {0} added to vehicle {1}", nokia.Model, porsche.Name);
            }
            //porsche.AddWheel();

            porsche.PrintData();

            Console.WriteLine();
        }
    }

    public class Wheel
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public Wheel()
        {
        }

        public override string ToString()
        {
            return "- Name: " + Model + ", model:  " + Type + ", tyre size:  " + Size;
        }


    }

    public class Vehicle
    {
        public string Name { get; set; }
        public string VehicleModel { get; set; }

        public List<Wheel> wheels = new List<Wheel>();
        public Vehicle()
        {
            
        }


        public void PrintData()
        {
            Console.WriteLine("Vehicle Name: {0} Model: {1}", Name, VehicleModel);
            foreach (Wheel wheel in wheels)
            {
                Console.WriteLine(wheel.ToString());
            }
        }

        //public void AddWheel(Wheel wheel)
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        wheels.Add(wheel);
        //        Console.WriteLine("Tyre {0} added to vehicle {1}", wheel.Model, Name);
        //    }
        //}
    }
}

