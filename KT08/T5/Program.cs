using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ohjelmat.txt");
            List<string> pList = new List<string>();

            TvOhjelma o1 = new TvOhjelma("Jackass",25,"00:00", "01:00","Johny Knoxville, Bam Margera getting down");
            TvOhjelma o2 = new TvOhjelma("Liverpool - ManUnited", 80, "14:30", "16:15", "Premier League fixture");
            TvOhjelma o3 = new TvOhjelma("No Reservations", 25, "18:30", "19:30", "RIP Anthony Bourdaine");
            TvOhjelma o4 = new TvOhjelma("South Park", 25, "19:30", "20:00", "Smiling faces everywhere, humble folks whithout temptations");

            pList.Add(o1.ToString());
            pList.Add(o2.ToString());
            pList.Add(o3.ToString());
            pList.Add(o4.ToString());

            foreach (string item in pList)
            {
                sw.WriteLine(item);
            }
            sw.Close();


            Console.WriteLine("Katsotut ohjelmat: ");
            foreach (string item in File.ReadAllLines("ohjelmat.txt"))
            {
                Console.WriteLine(item);
                Console.WriteLine("\n");
            }
        }
    }

    public class TvOhjelma
    {
        public string Nimi { get; set; }
        public int Kanava { get; set; }
        public string Alku { get; set; }
        public string Loppu { get; set; }
        public string Info { get; set; }

        public TvOhjelma()
        {

        }

        public TvOhjelma(string nimi, int kanava, string alku, string loppu, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            Alku = alku;
            Loppu = loppu;
            Info = info;
        }

        public override string ToString()
        {
            return string.Format("Ohjelma: {0} Kanava: {1} Alkaa: {2} Loppuu: {3} Info: {4}", Nimi, Kanava, Alku, Loppu, Info);
        }



    }
}
