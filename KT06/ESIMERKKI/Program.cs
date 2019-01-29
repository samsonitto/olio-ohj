using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIMERKKI
{
    //public abstract class Vehicle
    //{
    //    public abstract int TopSpeed { get; }
    //    public abstract string Accelerate;

    //}

    //public class Car : Vehicle
    //{
    //    private int topSpeed;

    //    public override int TopSpeed
    //    {
    //        get { return topSpeed; }
    //    }

    //    public override string Accelerate()
    //    {
    //        topSpeed += 10;
    //        return "Car is accelerating, speed is " + topSpeed;
    //    }

    //    static void Main()
    //    {
    //        Vehicle auto2 = new Car();
    //        Car auto = new Car();
    //        Console.WriteLine(auto2.Accelerate());
    //        Console.WriteLine(auto.Accelerate());
    //    }
    //}

    // ESIMERKKI 2

    //    class Tervehdys
    //    {
    //        public abstract class Moi
    //        {
    //            public abstract void Puhu();

    //            public virtual void Tervehdi()
    //            {
    //                Console.WriteLine("Kantaluokka sanoo MORO");
    //            }
    //        }

    //        public class Huuda : Moi // ei haittaa jos aluksi j‰‰ punaiseksi
    //        {
    //            public override void Puhu()
    //            {
    //                Console.WriteLine("Huudan sinulle");
    //            }

    //            public override void Tervehdi()
    //            {
    //                Console.WriteLine("Lapsiluokka sanoo MORO");
    //            }
    //        }

    //        static void Main()
    //        {
    //            Huuda olio = new Huuda();

    //            olio.Puhu();
    //            olio.Tervehdi();
    //        }
    //    }
    //}

    // ESIMERKKI 3 (Interface)

    //interface IAnimal
    //{
    //    string Name { get; set; }
    //    string Talk();
    //}

    //class Cat : IAnimal
    //{
    //    public string Name { get; set; }
    //    public string Talk()
    //    {
    //        return "MIAU";
    //    }
    //}

    //class Dog : IAnimal, ISika
    //{
    //    public string Name { get; set; }
    //    public string Viesti { get; set; }
    //    public string Talk()
    //    {
    //        return "WUF";
    //    }

    //    public string Tulostus()
    //    {
    //        return "Sika tuli mestoille";
    //    }

    //    public void Kokeilu()
    //    {
    //        Console.WriteLine("Toimiiko?");
    //    }

    //}

    //interface ISika
    //{
    //    string Name { get; set; }
    //    string Viesti { get; set; }
    //    string Tulostus();
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Cat cat = new Cat();
    //        Dog dog = new Dog();
    //        cat.Name = "Kisu";
    //        dog.Name = "Hauvva";

    //        //Console.WriteLine("Here is {0}: {1}", cat.Name, cat.Talk());
    //        Console.WriteLine("Here is {0}: {1} ja sen {2}", dog.Name, dog.Talk(), dog.Tulostus());
    //        Console.WriteLine(dog.Kokeilu());
    //    }
    //}

    //Esimerkki 4

    public interface ICanMakeANote
    {
        string MakeANote(string testToSave);
    }

    class Paper: ICanMakeANote
    {
        public int Sivu { get; set; }
        public string MakeANote(string txt)
        {
            return "scratch";
        }
    }

    class Cloud : ICanMakeANote
    {
        public string Operator { get; set; }

        public string MakeANote(string textToSave)
        {
            return "Saved to Cloud";
        }
    }

    class TestiMetodit
    {
        public static void TeeMuistiinPano(ICanMakeANote v‰line, string memo)
        {
            Console.WriteLine(v‰line.MakeANote(memo));
        }
    }

    class TestaaInterfacea
    {
        static void Testaa()
        {
            Paper suttupaperi = new Paper();
            Cloud pilvi = new Cloud();
            suttupaperi.Sivu = 231;
            pilvi.Operator = "Amazon";

            Console.WriteLine("Anna kirjoitettava teksti: ");
            string text = Console.ReadLine();
            //Console.WriteLine(suttupaperi.MakeANote(text));
            //Console.WriteLine(pilvi.MakeANote(text));

            TestiMetodit.TeeMuistiinPano(pilvi, text);
        }

        static void Main()
        {
            Testaa();
        }
    }
}