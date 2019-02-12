/*
Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön.
Kuinka voisit toteuttaa korttipakan sekoittamisen? Toteuta Korttipakka-luokalle Shuffle-metodi, joka sekoittaa pakan kortit satunnaiseen järjestykseen.
 */

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
            Random ran = new Random();
            List<string> pakka = new List<string>();
            Card p = new Card("p");
            Card h = new Card("h");
            Card ri = new Card("ri");
            Card ru = new Card("ru");

            for (int k = 1; k<14;k++ )
            {
                pakka.Add(String.Concat(p.Maa, k));
                pakka.Add(String.Concat(h.Maa, k));
                pakka.Add(String.Concat(ri.Maa, k));
                pakka.Add(String.Concat(ru.Maa, k));

            }

            Console.WriteLine("Uusi pakka: ");
            int i = 1;
            foreach (string item in pakka)
            {
                
                Console.WriteLine("{0} kortti on {1}",i,item);
                i++;
            }

            for(int j = 0; j<500;j++ )
            {
                int x = ran.Next(pakka.Count);
                int y = ran.Next(pakka.Count);
                string tmp = pakka[x];
                pakka[x] = pakka[y];
                pakka[y] = tmp;
            }

            Console.WriteLine("Sekoitettu pakka: ");

            i = 1;
            foreach (string item in pakka)
            {
                Console.WriteLine("{0} kortti on {1}", i, item);
                i++;
            }

        }
    }

    public class Card
    {
        public string Maa;
        public int Nro;

        public Card()
        {

        }
        public Card(string maa)
        {
            Maa = maa;
        }
    }
}
