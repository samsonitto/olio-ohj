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
            //MiniASIO asio = new MiniASIO();
            List<Opiskelija> miniAsio = new List<Opiskelija>();
            miniAsio.Add(new Opiskelija("0", "0", "0", "0"));
            miniAsio.Add(new Opiskelija("1", "1", "1", "1"));
            miniAsio.Add(new Opiskelija("2", "2", "2", "2"));
            //int i = 0;
            //string[] id = new string[10000];
            //id[i] = "0";
            int caseSwitch = 0;

            while (caseSwitch != 3)
            {

            Console.WriteLine(@"---------");
            Console.WriteLine(@"MiniASIO |");
            Console.WriteLine(@"---------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show all students");
            Console.WriteLine("3. Exit");

            Console.Write("Your choise > ");
            caseSwitch = int.Parse(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:

                        Console.Write("Etunimi: ");
                        string inputEnimi = Console.ReadLine();
                        Console.Write("Sukunimi: ");
                        string inputSnimi = Console.ReadLine();
                        string inputID = "000000000000";


                        bool arvo = true;

                        while (arvo)
                        {
                            Console.Write("AsioID: ");
                            inputID = Console.ReadLine();
                            //arvo = false;
                            Console.WriteLine(inputID);
                            foreach (Opiskelija o in miniAsio)
                            {
                                //Console.WriteLine(o);
                                if (o.AsioID == inputID)
                                {
                                    //Console.WriteLine(o.AsioID);
                                    arvo = true;
                                    Console.WriteLine("AsioID {0} on jo käytössä", inputID);
                                    break;
                                }
                                else
                                {
                                    arvo = false;
                                    Console.WriteLine("asd");
                                    break;
                                }
                            }

                            //if (arvo)
                            //{
                                
                            //}
                            //else { break; }
                        }

                        Console.Write("Ryhmä: ");
                        string inputRyh = Console.ReadLine();

                        miniAsio.Add(new Opiskelija()
                        {
                            Enimi = inputEnimi,
                            Snimi = inputSnimi,
                            AsioID = inputID,
                            Ryhma = inputRyh

                        });

                        break;

                    case 2: 
                        Console.Clear();
                        Console.WriteLine("Kaikki opiskelijat: ");
                        foreach (Opiskelija o in miniAsio)
                        {
                            Console.WriteLine(o.ToString());
                        }
                        //Console.Clear();
                        //asio.PrintData();
                        break;
                    case 3:
                        Console.WriteLine(miniAsio.ElementAt(0).ToString()); // 1 opiskelija
                        break;
                    case 4: 

                        break;
                }

            }
        }

        public class Opiskelija
        {
            public string Enimi { get; set; }
            public string Snimi { get; set; }
            public string AsioID { get; set; }
            public string Ryhma { get; set; }

            public Opiskelija()
            {

            }
            public Opiskelija(string enimi, string snimi)
            {
                Enimi = enimi;
                Snimi = snimi;
            }

            public Opiskelija(string enimi, string snimi, string asioId, string ryhma)
            {
                Enimi = enimi;
                Snimi = snimi;
                AsioID = asioId;
                ryhma = Ryhma;
            }



            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3}", Enimi, Snimi, AsioID, Ryhma);
            }
        }

        //public class MiniASIO
        //{
            

        //    public MiniASIO()
        //    {

        //    }


        //    public void PrintData()
        //    {
        //        Console.WriteLine("The all students in MiniASIO:");
        //        //foreach (Opiskelija item in miniAsio)
        //        //{
        //        //    Console.WriteLine(item.ToString());
        //        //}
        //    }
        //}
    }
}
