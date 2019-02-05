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
            CD MMLP = new CD();
            MMLP.Artist = "Eminem";
            MMLP.Name = "The Marshall Mathers LP";
            MMLP.Genre = "Rap";
            MMLP.Price = 19.99;
            MMLP.AddSongs();
            MMLP.PrintData();
        }
    }

    public class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public CD()
        {

        }

        public int songCounter = 0;
        public List<string> songs = new List<string>();

        public void AddSongs()
        {
            //Console.Write("Total amount of songs: ");
            //songCounter = int.Parse(Console.ReadLine());
            
            //Console.Write("Add song? y/n > ");
            //string input = Console.ReadLine();
            string song;
            string input;
            Console.WriteLine("Input 0 to stop adding songs");
            while (true)
            {
                
                Console.Write("Song > ");
                input = Console.ReadLine();

                if (input != "0")
                {
                    song = input;
                    songs.Add(song);
                }
                
                else
                {
                    break;
                }

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
