using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue jyp = new Joukkue();
            jyp.Nimi = "JYP";
            jyp.Kaupunki = "Jyväskylä";

            int caseSwitch = 0;

            while (caseSwitch != 6)
            {

                Console.WriteLine(@"----");
                Console.WriteLine(@"JYP |");
                Console.WriteLine(@"----");
                Console.WriteLine("1. Lisää pelaaja");
                Console.WriteLine("2. Listaa kaikki pelaajat");
                Console.WriteLine("3. Tallenna tiedostoon");
                Console.WriteLine("4. Tuo tiedostosta");
                Console.WriteLine("5. Poista pelaaja");

                Console.Write("Your choise > ");
                caseSwitch = int.Parse(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        jyp.AddPlayer();
                        break;
                    case 2:
                        jyp.PrintData();
                        break;
                    case 3:
                        jyp.Save();
                        break;
                    case 4:
                        jyp.Open();
                        break;
                    case 5:
                        jyp.RemoveP();
                        break;
                }

            }
        }
    }

    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hand { get; set; }
        public int Nro { get; set; }

        public Pelaaja()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Etunimi, Sukunimi, Hand, Nro);
        }
    }

    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> pelaajat = new List<Pelaaja>();

        public Joukkue()
        {

        }

        public void AddPlayer()
        {
            //Console.Write("Total amount of songs: ");
            //songCounter = int.Parse(Console.ReadLine());

            //Console.Write("Add song? y/n > ");
            //string input = Console.ReadLine();


            //Console.Write("Lisää pelaaja? y/n > ");
            string input = "y";//Console.ReadLine();

            while (input == "y")
            {

                Console.Write("Etunimi > ");
                string inputEnimi = Console.ReadLine();

                Console.Write("Sukunimi > ");
                string inputSnimi = Console.ReadLine();

                Console.Write("Kätisyys > ");
                string inputHand = Console.ReadLine();

                Console.Write("Pelinumero > ");
                int inputNro = int.Parse(Console.ReadLine());

                pelaajat.Add(new Pelaaja()
                {
                    Etunimi = inputEnimi,
                    Sukunimi = inputSnimi,
                    Hand = inputHand,
                    Nro = inputNro

                });

                Console.Write("Lisää pelaaja? y/n > ");
                input = Console.ReadLine();

                if(input != "y")
                {
                    break;
                }
            }
        }

        public void PrintData()
        {
            Console.Clear();
            Console.WriteLine("{0}   {1}", Nimi, Kaupunki);
            Console.WriteLine("**********************************");
            Console.WriteLine("Pelaajat: ");

            foreach(Pelaaja item in pelaajat)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Save()
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("jyp.txt");
            foreach(Pelaaja item in pelaajat)
            {
                outputFile.WriteLine(item);
            }
            outputFile.Close();
        }

        public void Open()
        {
            var lines = System.IO.File.ReadAllLines("G:\\Olio\\KT07\\T5\\bin\\Debug\\jyp.txt"); // var-tyyppinen lines muuttuja on kaikki csv:n rivit, paitsi ylin rivi

            foreach (string item in lines)
            {
                var values = item.Split(' '); // pilkkoo rivin

                pelaajat.Add(new Pelaaja() // lisää pelaajat taulukkoon tiedot
                {
                    Etunimi = values[0],
                    Sukunimi = values[1],
                    Hand = values[2],
                    Nro = int.Parse(values[3])
                });
            }
            Console.WriteLine("Databae loaded");
            Console.WriteLine();

        }

        public void RemoveP()
        {
            Console.WriteLine("Anna pelaajanumero > ");
            int inputR = int.Parse(Console.ReadLine());
            var item = pelaajat.SingleOrDefault(x => x.Nro == inputR);
            if (item != null)
                pelaajat.Remove(item);

        }
    }
}
