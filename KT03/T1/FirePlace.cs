using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class FirePlace
    {
        public string Name { get; set; }
        public int Humidity { get; set; }
        public int Heat { get; set; }
        public bool Power { get; set; }


        public FirePlace()
        {

        }

        public void Loyly()
        {
            Humidity += 1;
            Heat += 1;
        }

        public void Wait()
        {
            Humidity -= 1;
            Heat -= 1;
        }


        public void PrintData()
        {
            Console.WriteLine("Fireplace data: ");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("On/Off: {0}", Power);
            Console.WriteLine("Heat: {0}", Heat);
            Console.WriteLine("Humidity: {0}", Humidity);
        }
    }
}
