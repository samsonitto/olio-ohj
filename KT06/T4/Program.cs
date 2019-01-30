using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {


            Seura jyp = new Seura();
            jyp.Name = "JYP";
            jyp.Kaupunki = "Jyv‰skyl‰";

            var lines = System.IO.File.ReadAllLines("F:\\Olio\\KT06\\T4\\pelaajat.csv").Skip(1); // var-tyyppinen lines muuttuja on kaikki csv:n rivit, paitsi ylin rivi

            foreach (string item in lines)
            {
                var values = item.Split(','); // pilkkoo rivin

                jyp.pelaajat.Add(new Pelaaja() // lis‰‰ r taulukkoon tiedot
                {
                    Etunimi = values[0],
                    Sukunimi = values[1],
                    Pelipaikka = values[2],
                    K‰tisyys = values[3]
                });
            }

            //Pelaaja honka = new Pelaaja();
            //honka.Etunimi = "Anttoni";
            //honka.Sukunimi = "Honka";
            //honka.Pelipaikka = "p";
            //honka.K‰tisyys = "R";


            //Pelaaja laurikainen = new Pelaaja();
            //laurikainen.Etunimi = "Eetu";
            //laurikainen.Sukunimi = "Laurikainen";
            //laurikainen.Pelipaikka = "mv";
            //laurikainen.K‰tisyys = "L";

            //Pelaaja newton = new Pelaaja();
            //newton.Etunimi = "Jake";
            //newton.Sukunimi = "Newton";
            //newton.Pelipaikka = "p";
            //newton.K‰tisyys = "L";

            //Pelaaja kalteva = new Pelaaja();
            //kalteva.Etunimi = "Mikko";
            //kalteva.Sukunimi = "Kalteva";
            //kalteva.Pelipaikka = "p";
            //kalteva.K‰tisyys = "L";

            //Pelaaja tomasek = new Pelaaja();
            //tomasek.Etunimi = "David";
            //tomasek.Sukunimi = "Tomasek";
            //tomasek.Pelipaikka = "h";
            //tomasek.K‰tisyys = "R";

            //Pelaaja perrin = new Pelaaja();
            //perrin.Etunimi = "Erik";
            //perrin.Sukunimi = "Perrin";
            //perrin.Pelipaikka = "h";
            //perrin.K‰tisyys = "L";

            //Pelaaja tuppurainen = new Pelaaja();
            //tuppurainen.Etunimi = "Jani";
            //tuppurainen.Sukunimi = "Tuppurainen";
            //tuppurainen.Pelipaikka = "h";
            //tuppurainen.K‰tisyys = "L";




            //jyp.pelaajat.Add(laurikainen);
            //jyp.pelaajat.Add(newton);
            //jyp.pelaajat.Add(kalteva);
            //jyp.pelaajat.Add(tomasek);
            //jyp.pelaajat.Add(perrin);
            //jyp.pelaajat.Add(tuppurainen);
            //jyp.pelaajat.Add(honka);

            //jyp.WriteCSV(jyp.pelaajat, @"F:\Olio\KT06\T4\pelaajat.csv");

            jyp.PrintData();

           
        }
    }

    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string K‰tisyys { get; set; }

        public int PelaajaLaskuri { get; set; }

        public Pelaaja()
        {

        }

        

        public override string ToString()
        {
            return " -  " + Etunimi + " " + Sukunimi + ": " + Pelipaikka + ", " + K‰tisyys;
        }
    }

    public class Seura
    {
        public string Name { get; set; }
        public string Kaupunki { get; set; }

        public List<Pelaaja> pelaajat = new List<Pelaaja>();

        public Seura()
        {

        }

        public override string ToString()
        {
            return "Seura: " + Name + ", kaupunki: " + Kaupunki;
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
            foreach (Pelaaja pelaaja in pelaajat)
            {
                Console.WriteLine(pelaaja.ToString());
            }
        }

        public void WriteCSV<T>(IEnumerable<T> items, string path) // csv:hen tallennus aliohjelma, ei mit‰‰n hajua miten toimii
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //        .OrderBy(p => p.Name);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
    }


}
