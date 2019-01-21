/*
Tehtävä 6
Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa.
Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku.
Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi.
Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.
PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.
 */

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
            Random rand = new Random(); // luodaan uusi rand metoddi käyttämällä Random - luokkaa
            int[] randNum = new int[101]; // luodaan numerotaulukko
            int g = 0; // arvausten laskuri

            for (int i = 0;i<101 ;i++) // asetetaan numerot taulukkoon 1-100
            {
                randNum[i] = i;
            }

            int r = randNum[rand.Next(0, randNum.Length)]; // asetetaan arvattavissa oleva numero

            while (true) // peli pyörii niin kauan kun
            {
            Console.Write("Guess a number 0-100: "); // peli kysyy numeron pelajalta
            int num = int.Parse(Console.ReadLine()); // pelaaja antaa arvauksen
                if (num==r) // jos pelaaja arvaa numeron oikein
                {
                    g++; // arvausten laskuri
                    Console.WriteLine("Congrats! You won nothing and it took you " + g + " guesses!"); // peli päättyy ja pelaaja näkee monta arvausta hän käytti
                    break;
                }
                
                if (num < r) // jos numero on arvaus on pienempi kuin numero
                {
                    Console.WriteLine("Your number is smaller");
                    g++;
                }

                if (num > r) // jos arvaus on isompi kuin numero
                {
                    Console.WriteLine("Your number is bigger");
                    g++;
                }
            }
            //Console.WriteLine(r);

            /*
             * for (int j = 0; j < 101; j++)
            {
                Console.Write(randNum[j] + " ");
            }
            */
        }
    }
}
