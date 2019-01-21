/*
Teht�v� 7
Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusj�rjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sis�lt�.
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
            int[] array1 = { 10, 20, 30, 40, 50 }; // luodaan ensimm�inen taulukko
            int[] array2 = { 5, 15, 25, 35, 45 }; // luodaan toinen taulukko
            int[] cArray = array1.Concat(array2).ToArray(); // yhdistet��n taulukot uuteen taulukkoon

            Array.Sort(cArray); // lajitellaan numerot taulukossa


            //Tulostetaan taulukkoiden sis�ll�t
            Console.WriteLine("Array 1: " + string.Join(" ", array1));
            Console.WriteLine("Array 2: " + string.Join(" ", array2));
            Console.WriteLine("Combined Array: " + string.Join(" ", cArray));
            

        }
    }
}
