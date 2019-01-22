using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public CD()
        {

        }

        public int songCounter = 0;
        List<string> songs = new List<string>();
        public void AddSongs()
        {
            Console.Write("Total amount of songs: ");
            songCounter = int.Parse(Console.ReadLine());
            for (int i = 0; i < songCounter;i++ )
            {
                Console.Write("Song {0} > ", (i+1));
                songs.Add(Console.ReadLine());
            }
        }

        public void PrintData()
        {
            Console.WriteLine("CD:");
            Console.WriteLine("-Artist: {0}", Artist);
            Console.WriteLine("-Name: {0}", Name);
            Console.WriteLine("-Genre: {0}", Genre);
            Console.WriteLine("-Price: {0}$", Price);
            Console.WriteLine("Songs:");
            foreach (string track in songs)
            {
                Console.Write("--- Name: ");
                System.Console.WriteLine(track);
            }
        }
    }
}
