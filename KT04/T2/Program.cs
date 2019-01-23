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
            Elevator dynamo = new Elevator();
            dynamo.Floor = 1;
            while (true)
            {

                Console.WriteLine("Elevator is now in floor : {0}", dynamo.Floor);
                dynamo.SetFloor();
            }
        }
    }

    public class Elevator
    {
        private readonly int MaxFloor = 5;
        private readonly int MinFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < MinFloor)
                {
                    Console.WriteLine("The floor is too small");

                }

                else if (value > MaxFloor)
                {
                    Console.WriteLine("The floor is too big");
                }

                else
                {
                    floor = value;
                }
            }
        }

        public void SetFloor()
        {
            Console.Write("Give a new floor number (1-5) > ");
            Floor = int.Parse(Console.ReadLine());
        }
    }
}
