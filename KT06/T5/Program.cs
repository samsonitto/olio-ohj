using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen jebe = new Ihminen();
            jebe.ik� = 31;
            jebe.Nimi = "Jesse";
            jebe.Paino = 50;
            jebe.Pituus = 182;
            jebe.Kasva();
            
            Console.WriteLine(jebe.ToString());
            Console.WriteLine(jebe.Liiku());

            Vauva alvar = new Vauva();
            alvar.ik� = 1;
            alvar.Nimi = "Alvar";
            alvar.Paino = 3;
            alvar.Pituus = 47;
            alvar.Vaippa = "Pampers";
            alvar.Kasva();
            
            Console.WriteLine(alvar.ToString());
            Console.WriteLine(alvar.Liiku());

            Aikiunen alina = new Aikiunen();
            alina.ik� = 30;
            alina.Nimi = "Alina";
            alina.Paino = 65;
            alina.Pituus = 170;
            alina.Auto = "Tesla";
            alina.Kasva();
            
            Console.WriteLine(alina.ToString());
            Console.WriteLine(alina.Liiku());
        }
    }

    public abstract class Nisakas
    {
        public abstract int Ik� { get; }

        public abstract string Liiku();


    }

    public class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public int ik�;
        public override int Ik� { get { return ik�; } }

        public override string Liiku()
        {
            return "Liikun";
        }

        public void Kasva()
        {
            ik� += 1;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + ", ik�: " + Ik� + ", paino: " + Paino + ", pituus: " + Pituus;
        }
    }

    public class Vauva : Ihminen
    {

        public string Vaippa { get; set; }
        public override string Liiku()
        {
            return "Konttaa";
        }

        public override string ToString()
        {
            return base.ToString() + ", vaippa: " + Vaippa;
        }
    }

    public class Aikiunen : Ihminen
    {
        public string Auto { get; set; }

        public override string Liiku()
        {
            return "K�velee";
        }

        public override string ToString()
        {
            return base.ToString() + ", auto: " + Auto;
        }
    }
}
