/*
Tehtävä 7
Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 20, 30, 40, 50 }; // luodaan ensimmäinen taulukko
            int[] array2 = { 5, 15, 25, 35, 45 }; // luodaan toinen taulukko
            int[] cArray = array1.Concat(array2).ToArray(); // yhdistetään taulukot uuteen taulukkoon

            Array.Sort(cArray); // lajitellaan numerot taulukossa


            //Tulostetaan taulukkoiden sisällöt
            Console.WriteLine("Array 1: " + string.Join(" ", array1));
            Console.WriteLine("Array 2: " + string.Join(" ", array2));
            Console.WriteLine("Combined Array: " + string.Join(" ", cArray));
            

        }
    }
}
