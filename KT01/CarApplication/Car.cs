using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }


        public Car()
        {

        }


        public Car(string model, string color, double engine)
        {
            Model = model;
            Color = color;
            Engine = engine;
        }

        public void Accelerate()
        {
            Speed += 5;
        }

        public void Brake()
        {
            Speed -= 5;
        }

        public void PrintData()
        {
            Console.WriteLine("Car data: ");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Engine: {0:F2}", Engine);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Fuzzy dices: {0}", FuzzyDices);
            Console.WriteLine("Door count: {0}", DoorCount);
            Console.WriteLine("Some Static Property: {0}", SomeProperty);
        }

        ~Car()
        {
            Console.WriteLine("Object destroyed!");
        }
    }
}
