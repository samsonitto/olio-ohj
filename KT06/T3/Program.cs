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
            laurikainen.K�tisyys = "L";

            Pelaaja newton = new Pelaaja();
            newton.Etunimi = "Jake";
            newton.Sukunimi = "Newton";
            newton.Pelipaikka = "p";
            newton.K�tisyys = "L";

            Pelaaja kalteva = new Pelaaja();
            kalteva.Etunimi = "Mikko";
            kalteva.Sukunimi = "Kalteva";
            kalteva.Pelipaikka = "p";
            kalteva.K�tisyys = "L";

            Pelaaja tomasek = new Pelaaja();
            tomasek.Etunimi = "David";
            tomasek.Sukunimi = "Tomasek";
            tomasek.Pelipaikka = "h";
            tomasek.K�tisyys = "R";

            Pelaaja perrin = new Pelaaja();
            perrin.Etunimi = "Erik";
            perrin.Sukunimi = "Perrin";
            perrin.Pelipaikka = "h";
            perrin.K�tisyys = "L";

            Pelaaja tuppurainen = new Pelaaja();
            tuppurainen.Etunimi = "Jani";
            tuppurainen.Sukunimi = "Tuppurainen";
            tuppurainen.Pelipaikka = "h";
            tuppurainen.K�tisyys = "L";

            Seura jyp = new Seura();
            jyp.Name = "JYP";
            jyp.Kaupunki = "Jyv�skyl�";

            
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
        public string K�tisyys { get; set; }

        public int PelaajaLaskuri { get; set; }

        public Pelaaja()
        {

        }

        public override string ToString()
        {
            return " -  " + Etunimi + " " + Sukunimi + ": " + Pelipaikka + ", " + K�tisyys;
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
