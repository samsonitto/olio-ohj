/*
 * 
 * ESIM 1
 * 
using System;

namespace Esimerkit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!"); // sama kuin System.Console.WriteLine("Hello World!");
            Console.ReadKey(); // sama kuin System("Pause");
        }
    }

    namespace Lorppa
    {
        class Program // voi olla samalla nimell‰, koska on eri namespacessa
        {

        }
    }
}
*/



// ESIM 2

/*
using System;

namespace OmaNamespace
{
    public class Luokka // publicilla voi k‰ytt‰‰ samaa Luokkaa muualla
    {
        public static void OmaMetodi() // voi k‰ytt‰‰ muualla
        {
            Console.WriteLine("Terve kaikki");
        }
    }
}

namespace OmaOhjelma
{
    class Luokka
    {
        static void Main()  // pit‰‰ olla iso "M"
        {
            OmaNamespace.Luokka.OmaMetodi(); // kutsu
            Console.ReadKey();
        }
    }
}
*/

// ESIM 3

/*
using System;

namespace Esimerkki
{
    class Luokka
    {
        static void Main()
        {
            // both numbers are stored in a stack. Both have own memory allocation.
            int numberA = 100;
            int numberB = 200;

            // set numberA to numberB
            numberB = numberA;
            numberA = 300;
            Console.WriteLine(numberA); // prints 300
            Console.WriteLine(numberB); // prints 100

            int number = 10;
            Add(number); // value type
            Console.WriteLine("number = " + number); // prints 10

            Add2(ref number); // reference typ
            Console.WriteLine("number = " + number); // prints 11

        }
        
        // method
        static void Add(int number) // copy, original doesn't change
        {
            number++;
        }

        // method
        static void Add2(ref int number)
        {
            number++;
        }
    }
}
*/


// ESIM 4 "enum"

/*
 * using System;

namespace Enumi
{
    class EnumiLuokka
    {
        enum ViikonPaiva
        {
            Maanantai = 1, Tiistai, Keskiviikko, Torstai // index on 1, muuten alkaisi 0:sta
        }

        static void Main()
        {
            Console.WriteLine("Enumissa on seuraavat paivat: ");

            foreach (string str in Enum.GetNames(typeof(ViikonPaiva)))
                Console.WriteLine(str);

            Console.WriteLine("yksittainen arvo enumista");
            Console.WriteLine(Enum.GetName(typeof(ViikonPaiva), 2));
        }
    }
}
*/


// ESIM 4 "taulukko"

/*
 * using System;

namespace Taulukko
{
    class OmaTaulukko
    {
        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0 ; i < 10 ; i++) // taulukon paikka
            {
                numbers[i] = i + 1;
            }

            for (int j = 0 ; j<numbers.Length ;j++ ) // tulostus
            {
                Console.WriteLine(numbers[j]);
            }
        }
    }
}
*/


//ESIM 5 "do while"

using System;

namespace Moi
{
    class Terve
    {
        static void Main()
        {
            int number;

            Random rand = new Random();

            do
            {
                number = rand.Next(11);
                Console.WriteLine(number);
            } while (number != 10);
        }
    }
}