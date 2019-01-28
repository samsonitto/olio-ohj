using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio minunRadio = new Radio();
            minunRadio.Name = "Samsonin radio";
            minunRadio.Model = "Creative";
            minunRadio.OnOff = true;
            minunRadio.SetVolume();
            minunRadio.VolumeUp();
            minunRadio.SetFrequency();
            Console.WriteLine(minunRadio.ToString());
        }
    }

    public class Radio
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public bool OnOff { get; set; }
        public int Volume { get; set; }
        public double Frequency { get; set; }

        public Radio()
        {

        }

        public void VolumeUp()
        {
            if (OnOff == true)
            {
                if (Volume < 9)
                {
                    Volume += 1;
                }
                else
                {
                    Volume = 9;
                }
            }

        }

        public void VolumeDown()
        {
            if (OnOff == true)
            {
                if (Volume > 0)
                {
                    Volume -= 1;
                }

                else
                {
                    Volume = 0;
                }
            }
        }

        public void SetVolume()
        {
            Console.Write("Volume (0-9) > ");
            Volume = int.Parse(Console.ReadLine());

            while (Volume < 0 || Volume > 9)
            {
 
                if (Volume<0 || Volume > 9)
                {
                    Console.WriteLine("Wrong value, try gain");
                }
                Console.Write("Volume (0-9) > ");
            Volume = int.Parse(Console.ReadLine());
            }
        }

        public void SetFrequency()
        {
            Frequency = 2000.0;

            Console.Write("Frequency (2000.0 - 26000.0) > ");
            Frequency = double.Parse(Console.ReadLine());

            while (Frequency < 2000.0 || Frequency > 26000.0)
            {

                if (Frequency < 2000.0 || Frequency > 26000.0)
                {
                    Console.WriteLine("Wrong value, try gain");
                }

                Console.Write("Frequency (2000.0 - 26000.0) > ");
                Frequency = int.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return "- Name: " + Name + ", Model: " + Model + ", Frequency: " + Frequency + ", Volume: " + Volume;
        }
    }
}
