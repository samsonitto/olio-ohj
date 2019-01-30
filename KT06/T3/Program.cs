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
            Pelaaja laurikainen = new Pelaaja();
            laurikainen.Etunimi = "Eetu";
            laurikainen.Sukunimi = "Laurikainen";
            laurikainen.Pelipaikka = "mv";
            laurikainen.Kätisyys = "L";

            Pelaaja newton = new Pelaaja();
            newton.Etunimi = "Jake";
            newton.Sukunimi = "Newton";
            newton.Pelipaikka = "p";
            newton.Kätisyys = "L";

            Pelaaja kalteva = new Pelaaja();
            kalteva.Etunimi = "Mikko";
            kalteva.Sukunimi = "Kalteva";
            kalteva.Pelipaikka = "p";
            kalteva.Kätisyys = "L";

            Pelaaja tomasek = new Pelaaja();
            tomasek.Etunimi = "David";
            tomasek.Sukunimi = "Tomasek";
            tomasek.Pelipaikka = "h";
            tomasek.Kätisyys = "R";

            Pelaaja perrin = new Pelaaja();
            perrin.Etunimi = "Erik";
            perrin.Sukunimi = "Perrin";
            perrin.Pelipaikka = "h";
            perrin.Kätisyys = "L";

            Pelaaja tuppurainen = new Pelaaja();
            tuppurainen.Etunimi = "Jani";
            tuppurainen.Sukunimi = "Tuppurainen";
            tuppurainen.Pelipaikka = "h";
            tuppurainen.Kätisyys = "L";

            Seura jyp = new Seura();
            jyp.Name = "JYP";
            jyp.Kaupunki = "Jyväskylä";

            
            jyp.pelaajat.Add(laurikainen);
            jyp.pelaajat.Add(newton);
            jyp.pelaajat.Add(kalteva);
            jyp.pelaajat.Add(tomasek);
            jyp.pelaajat.Add(perrin);
            jyp.pelaajat.Add(tuppurainen);

            jyp.PrintData();

        }
    }

    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }

        public int PelaajaLaskuri { get; set; }

        public Pelaaja()
        {

        }

        public override string ToString()
        {
            return " -  " + Etunimi + " " + Sukunimi + ": " + Pelipaikka + ", " + Kätisyys;
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
            foreach(Pelaaja pelaaja in pelaajat)
            {
                Console.WriteLine(pelaaja.ToString());
            }
        }
    }
}
