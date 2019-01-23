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
            Vahvistin omaVahvistin = new Vahvistin();
            while (true)
            {
                omaVahvistin.SetVolume();
            }
        }
    }

    public class Vahvistin
    {
        private readonly int MaxVolume = 100;
        private readonly int MinVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
                    volume = MinVolume;
                }
                else if (value > MaxVolume)
                {
                    Console.WriteLine("Too much volume -  Amplifier volume is set to maximum : 100");
                    volume = MaxVolume;
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Amplifier volume is set to: {0}", volume);
                }
            }
        }

        public void SetVolume()
        {
            Console.Write("Give a new volume value: ");
            Volume = int.Parse(Console.ReadLine());
        }
    }
}
