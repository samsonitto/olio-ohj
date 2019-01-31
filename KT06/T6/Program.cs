using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Con ps4 = new Con();
            ps4.Name = "Playstation 4";
            ps4.Manufacturer = "Sony";
            ps4.Price = 399.90;

            Games fifa19 = new Games();
            fifa19.Name = "FIFA 19";
            fifa19.Manufacturer = "EA Sports";
            fifa19.Price = 54.90;
            fifa19.Genre = "Sports simulator";

            Games gta5 = new Games();
            gta5.Name = "GTA V";
            gta5.Manufacturer = "Rockstar Games";
            gta5.Price = 54.90;
            gta5.Genre = "Action-adventure";

            Games rdr2 = new Games();
            rdr2.Name = "Red Dead Redemption 2";
            rdr2.Manufacturer = "Rockstar Games";
            rdr2.Price = 64.90;
            rdr2.Genre = "Action-adventure";

            Games starCitizen = new Games();
            starCitizen.Name = "Star Citizen";
            starCitizen.Manufacturer = "Cloud Imperium Games";
            starCitizen.Price = 54.90;
            starCitizen.Genre = "Space trading and combat";

            Games pubg = new Games();
            pubg.Name = "PLAYERUNKNOWN's Battleground";
            pubg.Manufacturer = "PUBG Corporation";
            pubg.Price = 24.90;
            pubg.Genre = "Battle Royale";

            ps4.library.Add(fifa19);
            ps4.library.Add(gta5);
            ps4.library.Add(rdr2);
            ps4.library.Add(starCitizen);
            ps4.library.Add(pubg);

            //Console.WriteLine(ps4.ToString());
            
           // ps4.PrintData();

            Con pc = new Con();
            pc.Name = "Personal Computer";
            pc.Manufacturer = "various";
            pc.Price = 2399.90;

            Games scum = new Games();
            scum.Name = "SCUM";
            scum.Manufacturer = "Devolver Digital";
            scum.Price = 34.90;
            scum.Genre = "Survival";

            Games dayz = new Games();
            dayz.Name = "DayZ";
            dayz.Manufacturer = "Bohemia Interactive";
            dayz.Price = 44.90;
            dayz.Genre = "Survival";

            Games csgo = new Games();
            csgo.Name = "Counter-Strike: Global Offensive";
            csgo.Manufacturer = "Valve";
            csgo.Price = 24.90;
            csgo.Genre = "	First-person shooter";

            Games ark = new Games();
            ark.Name = "Ark: Survival Evolved";
            ark.Manufacturer = "Studio Wildcard";
            ark.Price = 54.90;
            ark.Genre = "Survival";

            Games bf4 = new Games();
            bf4.Name = "Battlefield 4";
            bf4.Manufacturer = "EA";
            bf4.Price = 14.90;
            bf4.Genre = "First-person shooter";



            pc.library.Add(csgo);
            pc.library.Add(ark);
            pc.library.Add(bf4);
            pc.library.Add(dayz);
            pc.library.Add(pubg);
            pc.library.Add(scum);

            //Console.WriteLine(ps4.ToString());
            //Console.WriteLine("=================================================================");
            ps4.PrintData();

            //Console.WriteLine(pc.ToString());
            //Console.WriteLine("=================================================================");
            pc.PrintData();

        }
    }

    public class Con
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public List<Games> library =new  List<Games>();
        public List<Games> pcLibrary = new List<Games>();

        public Con()
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", made by: " + Manufacturer + ", price: " + Price + "$";
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("=================================================================");
            Console.WriteLine("Game Library:");
            foreach (Games item in library)
            {
                Console.WriteLine("- " + item.ToString());
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }

            foreach (Games item in pcLibrary)
            {
                Console.WriteLine("- " + item.ToString());
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
        }


    }

    public class Games : Con
    {
        public string Genre { get; set; }

        public Games()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", genre: " + Genre;
        }
    }
}
