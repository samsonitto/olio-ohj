/*
 Tee delegaateilla ohjelma, jolla käyttäjä syöttää merkkijonon. Sen jälkeen käyttäjä voi valita yhden tai useamman toiminnon jota merkkijonolle tehdään. Merkkijonolle pitää pystyä tekemään seuraavat toiminnot:
- muuttaa merkkijonon kaikki kirjaimet isoiksi kirjaimiksi
- muuttaa merkkijonon kaikki kirjaimet pieniksi kirjaimiksi
- muuttaa merkkijonon Otsikko-tyyllin, eli ensimmäinen merkki isolla ja loput pienellä
- kääntää merkkijonon toistepäin eli sanasta Teppo tulee oppeT.
Eli toteuta kutakin muunnosta varten oma metodi (kaikilla metodeilla täytyy olla sama signature). Luo delegaatista instanssi ja kiinnitä siihen tarvittavat metodit. Voilá.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_delegate
{
    class Testi
    {
        delegate void FormatoiSana(string input);

        static void Main()
        {
            FormatoiSana format;

            while (true)
            {

                Console.Write("Anna merkkijono > ");
                string input = Console.ReadLine();

                string valinta;

                Console.WriteLine("Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla > ");
                Console.WriteLine("1 Isoiksi kirjaimiksi");
                Console.WriteLine("2 Otsikoksi");
                Console.WriteLine("3 Pieniksi kirjaimiksi");
                Console.WriteLine("4 Palindromiksi");
                Console.WriteLine("0 Lopetus");
                valinta = Console.ReadLine();


                if (valinta == "0")
                {
                    break;
                }

                for (int i = 0; i < valinta.Length; i++)
                {


                    if (valinta[i] == '1')
                    {
                        format = Formatoi1;
                        format(input);
                    }
                    if (valinta[i] == '2')
                    {
                        format = Formatoi2;
                        format(input);
                    }
                    if (valinta[i] == '3')
                    {
                        format = Formatoi3;
                        format(input);
                    }
                    if (valinta[i] == '4')
                    {
                        format = Formatoi4;
                        format(input);
                    }
                        

                }

                
            }

        }

        static void Formatoi1(string input)
        {
            Console.WriteLine("{0} on muutettu muotoon {1}",input,input.ToUpper());
        }

        static void Formatoi2(string input)
        {
            
            StringBuilder s = new StringBuilder(char.ToUpper(input[0])+input.Substring(1));
            Console.WriteLine("{0} on muutettu muotoon {1}",input, s);
        }

        static void Formatoi3(string input)
        {
            Console.WriteLine("{0} on muutettu muotoon {1}", input, input.ToLower());
        }

        static void Formatoi4(string input)
        {

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string pali = new string(arr);
            Console.WriteLine("{0} on muutettu muotoon {1}", input, pali);
        }
    }

}
