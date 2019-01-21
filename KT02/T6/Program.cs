/*
Teht�v� 6
Tee ohjelma, joka arpoo satunnaisluvun v�lilt� 0-100. K�yt� C#:n Random -luokkaa.
T�m�n j�lkeen ohjelman k�ytt�j�� kehoitetaan arvaaman arvottu luku.
Ohjelman tulee antaa vihje arvauksen j�lkeen onko arvottu luku pienem�i vai suurempi.
T�m�n j�lkeen vihjeit� toistetaan kunnes k�ytt�j� arvaa oikean luvun. Tulosta lopuksi arvausten m��r� n�yt�lle.
PS Satunnaislukujen arpomisesta tietokoneella l�ytyy mielenkiintoista luettavaa esimerkiksi t�st� artikkelista: Computers are lousy random number generators.
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
            Random rand = new Random(); // luodaan uusi rand metoddi k�ytt�m�ll� Random - luokkaa
            int[] randNum = new int[101]; // luodaan numerotaulukko
            int g = 0; // arvausten laskuri

            for (int i = 0;i<101 ;i++) // asetetaan numerot taulukkoon 1-100
            {
                randNum[i] = i;
            }

            int r = randNum[rand.Next(0, randNum.Length)]; // asetetaan arvattavissa oleva numero

            while (true) // peli py�rii niin kauan kun
            {
            Console.Write("Guess a number 0-100: "); // peli kysyy numeron pelajalta
            int num = int.Parse(Console.ReadLine()); // pelaaja antaa arvauksen
                if (num==r) // jos pelaaja arvaa numeron oikein
                {
                    g++; // arvausten laskuri
                    Console.WriteLine("Congrats! You won nothing and it took you " + g + " guesses!"); // peli p��ttyy ja pelaaja n�kee monta arvausta h�n k�ytti
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
