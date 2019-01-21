using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void Accelerate()
        {
            Speed += 10;
        }

        public void Brake()
        {
            Speed += 10;
        }

        public void SetTyres()
        {
            Tyres += 1;
        }

        public void PrintData()
        {
            Console.WriteLine("The vehicle data: ");
            Console.WriteLine("Model: {0}", Name);
            Console.WriteLine("Current speed: {0}", Speed);
            Console.WriteLine("Equipped tyres: {0}", Tyres);
        }

        public override string ToString()
        {
            return "Model: " + Name + ", current speed: " + Speed + ", Tyres (1 = winter, 0 = summer): " + Tyres;
        }

    }
}
