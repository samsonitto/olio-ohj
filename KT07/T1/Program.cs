using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniASIO asio = new MiniASIO();

            int caseSwitch = 0;

            while (caseSwitch != 6)
            {

            Console.WriteLine(@"------------------");
            Console.WriteLine(@"MiniASIO DATABASE |");
            Console.WriteLine(@"------------------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show all students");
            Console.WriteLine("3. Show the latest student");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Import from file");
            Console.WriteLine("6. Exit");

            Console.Write("Your choise > ");
            caseSwitch = int.Parse(Console.ReadLine());


                switch (caseSwitch)
                {

                    case 1:

                        Console.Write("Etunimi: ");
                        string inputEnimi = Console.ReadLine();
                        Console.Write("Sukunimi: ");
                        string inputSnimi = Console.ReadLine();
                        Console.Write("AsioID: ");
                        string inputID = Console.ReadLine();
                        Console.Write("Ryhmä: ");
                        string inputRyh = Console.ReadLine();
                        asio.miniAsio.Add(new Opiskelija()
                        {
                            Enimi = inputEnimi,
                            Snimi = inputSnimi,
                            AsioID = inputID,
                            Ryhmä = inputRyh

                        });
                        Console.Clear();
                        break;

                    case 2: // tulostaa kaikki tulokset
                        Console.Clear();
                        asio.PrintData();
                        break;
                    case 3: // tulostaa viimeisimman tuloksen

                        break;
                    case 4: // tallentaa tiedostoon

                        break;
                    case 5:  // tuo tiedostosta

                        break;
                }
                //Opiskelija o1 = new Opiskelija();
                //o1.Enimi = "Masa";
                //o1.Snimi = "Niemi";
                //asio.miniAsio.Add(o1);

                //Opiskelija o2 = new Opiskelija();
                //o2.Enimi = "Allan";
                //o2.Snimi = "Aalto";
                //o2.AsioID = "A1111";
                //asio.miniAsio.Add(o2);

                //Opiskelija o3 = new Opiskelija();
                //o3.Enimi = "Hanna";
                //o3.Snimi = "Husso";
                //o3.AsioID = "B2222";
                //asio.miniAsio.Add(o3);

                //Opiskelija o4 = new Opiskelija();
                //o4.Enimi = "Teppo";
                //o4.Snimi = "Testaaja";
                //o4.AsioID = "C3333";
                //asio.miniAsio.Add(o4);




            }
        }

        public class Opiskelija
        {
            public string Enimi { get; set; }
            public string Snimi { get; set; }
            public string AsioID { get; set; }
            public string Ryhmä { get; set; }

            public Opiskelija()
            {

            }

            public Opiskelija(string enimi, string snimi, string asioId, string ryhmä)
            {
                Enimi = enimi;
                Snimi = snimi;
                asioId = AsioID;
                ryhmä = Ryhmä;
            }

            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}", Enimi, Snimi, AsioID, Ryhmä);
            }
        }

        public class MiniASIO
        {
            public List<Opiskelija> miniAsio = new List<Opiskelija>();

            public MiniASIO()
            {

            }

            public void PrintData()
            {
                Console.WriteLine("The all students in MiniASIO:");
                foreach (Opiskelija item in miniAsio)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
