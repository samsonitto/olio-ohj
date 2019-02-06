using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_delegate
{
    class Testi
    {
        //public delegate int Laskin(int x, int y);
        delegate void FormatoiLuku(double luku);

        static void Main()
        {
            //Matikka math = new Matikka();

            //Laskin la = new Laskin(math.Lisaa);

            //Console.WriteLine(la(5,5));

            //la = new Laskin(math.Kertaa);
            //int tulos = la(5,5);
            //Console.WriteLine(tulos);

            Console.Write("Anna desimaali: ");
            string syote = Console.ReadLine();

            double arvo;
            // bool tulos = double.TryParse(syote, out arvo)
            if(double.TryParse(syote, out arvo))
            {
                //FormatoiLuku format = Formatoi1;
                FormatoiLuku format = new FormatoiLuku(Formatoi1); // toimii samalla tavalla ku ylempi
                format += Formatoi2;
                format(arvo);
            }

        }

        static void Formatoi1(double luku)
        {
            Console.WriteLine("Annettu luku valuuttana ja {0:C}", luku);
        }

        static void Formatoi2(double luku)
        {
            Console.WriteLine("Annettu luku 3 tarkkuudella {0:.###}", luku);
        }
    }

    //public class Matikka
    //{
    //    public int Lisaa(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    public int Kertaa(int x, int y)
    //    {
    //        return x * y;
    //    }
    //}
}
