using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class MyFishApp
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<Fisherman> fisherman = new List<Fisherman>();
            List<Fish> fish = new List<Fish>();
            int id = 0;

            while (input != 4)
            {
                Console.WriteLine("\n**************|");
                Console.WriteLine("KALAREKISTERI |");
                Console.WriteLine("______________|");
                Console.WriteLine("1. Lisää kalastaja ja sen kalat");
                Console.WriteLine("2. Tulosta kalastajarekisteri");
                Console.WriteLine("3. Tulosta kalarekisteri painon mukaan lajiteltuna");
                Console.WriteLine("4. Sulje");
                Console.Write("Valintasi > ");
                input = int.Parse(Console.ReadLine());

                
                if (input == 1)
                {
                    
                    Console.Write("Anna kalastajan nimi > ");
                    string inputName = Console.ReadLine();
                    Console.Write("Anna kalastajan puhnro > ");
                    string inputPhone = Console.ReadLine();
                    id++;
                    fisherman.Add(new Fisherman() { Name = inputName, Phone = inputPhone, ID = id });

                    string inputFish = "y";

                    while (inputFish == "y")
                    {
                        Console.Write("Anna kalan laji > ");
                        string inputType = Console.ReadLine();
                        Console.Write("Anna kalan pituus > ");
                        int inputHeight = int.Parse(Console.ReadLine());
                        Console.Write("Anna kalan paino > ");
                        double inputWeight = double.Parse(Console.ReadLine());
                        Console.Write("Anna kalastuspaikka > ");
                        string inputPlace = Console.ReadLine();
                        Console.Write("Anna kalastussijainti > ");
                        string inputLocation = Console.ReadLine();

                        fish.Add(new Fish() { Type = inputType, Lenght = inputHeight, Weight = inputWeight, Place = inputPlace, Location = inputLocation, FishID = id });

                        Console.Write("Lisää kala? y/n > ");
                        inputFish = Console.ReadLine();

                    }

                }

                if (input == 2)
                {
                    foreach(Fisherman fm in fisherman)
                    {
                        Console.WriteLine(fm.ToString());
                        foreach(Fish f in fish)
                        {
                            if(f.FishID == fm.ID)
                            {
                                Console.WriteLine(f.ToString());
                            }
                        }
                    }
                }

                if (input == 3)
                {
                    List<Fish> sortedFish = fish.OrderBy(o => o.Weight).ToList();
                    foreach (Fish f in sortedFish)
                    {
                        Console.WriteLine(f.ToString());
                        foreach(Fisherman fm in fisherman)
                        {
                            if (fm.ID == f.FishID)
                            {
                                Console.WriteLine("- Fisherman: " + fm.Name);
                            }
                        }
                    }
                }

            }
        }
    }

    public class Fisherman
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public int ID { get; set; }



        //public List<Fisherman> fisherman = new List<Fisherman>();

        
        public Fisherman()
        {

        }


        public override string ToString()
        {
            return string.Format("Kalastaja {0} sai seuraavat kalat:", Name);
        }
    }

    public class Fish
    {
        public string Type { get; set; }
        public int Lenght { get; set; }
        public double Weight { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }

        public int FishID { get; set; }

        //public List<Fish> fish = new List<Fish>();

        public Fish()
        {

        }


        public override string ToString()
        {
            return string.Format("\n- specie: {0} {1}cm {2}kg \n- place: {3} \n- location: {4}", Type, Lenght, Weight, Place, Location);
        }


    }
}
