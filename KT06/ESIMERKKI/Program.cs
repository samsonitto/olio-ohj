//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ESIMERKKI
//{
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

//    public interface ICanMakeANote
//    {
//        string MakeANote(string testToSave);
//    }

//    class Paper: ICanMakeANote
//    {
//        public int Sivu { get; set; }
//        public string MakeANote(string txt)
//        {
//            return "scratch";
//        }
//    }

//    class Cloud : ICanMakeANote
//    {
//        public string Operator { get; set; }

//        public string MakeANote(string textToSave)
//        {
//            return "Saved to Cloud";
//        }
//    }

//    class TestiMetodit
//    {
//        public static void TeeMuistiinPano(ICanMakeANote v‰line, string memo)
//        {
//            Console.WriteLine(v‰line.MakeANote(memo));
//        }
//    }

//    class TestaaInterfacea
//    {
//        static void Testaa()
//        {
//            Paper suttupaperi = new Paper();
//            Cloud pilvi = new Cloud();
//            suttupaperi.Sivu = 231;
//            pilvi.Operator = "Amazon";

//            Console.WriteLine("Anna kirjoitettava teksti: ");
//            string text = Console.ReadLine();
//            //Console.WriteLine(suttupaperi.MakeANote(text));
//            //Console.WriteLine(pilvi.MakeANote(text));

//            TestiMetodit.TeeMuistiinPano(pilvi, text);
//        }

//        static void Main()
//        {
//            Testaa();
//        }
//    }
//}




//Esimerkki5 (Assosiation)

//using System;

//    /* Association:
//       - Teacher uses IDCard, but IDcard has his own life
//    */
//    namespace Association
//    {

//        class Teacher
//        {
//            public void UseCard(IDCard card)
//            {
//                Console.WriteLine("Teacher users IDCard : " + card.Name);
//            }

//            ~Teacher() // ~ on olion/luokan tuhoaja
//        {
//                Console.WriteLine("Teacher is destructed");
//            }
//        }

//        class IDCard
//        {

//            public string Name { get; set; }
//            public IDCard(string name)
//            {
//                Name = name;
//            }

//            ~IDCard() // ~ on olion/luokan tuhoaja
//            {
//                Console.WriteLine("IDCard " + Name + " is destructed");
//            }

//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                // create Teacher
//                Teacher teacher = new Teacher();
//                // create card
//                IDCard card = new IDCard("MasterCard");
//                // Teacher uses card
//                teacher.UseCard(card); // prints:  Teacer users IDCard : MasterCard
//                                       // null teacher :-)
//                teacher = null;

//                /*
//                 * Call Garbage Collector to remove unneeded objects, 
//                 * by default GC removes when nessessary (in small apps
//                 * when they are closed).
//                 */

//                GC.Collect(); // prints: Teacher is destructed
//                              // Note! card is not destructed, it has own life!

//                Console.ReadLine();

//            }
//        }
//    }



// ESIMERKKI 6: Composition

//using System;

///* Composition is a special type of association
//   - JAMK owns Department. Department can't live on without JAMK
//   - When JAMK dies, Department dies too
//*/

//namespace Composition
//{
//    class JAMK
//    {
//        private Department department = new Department();

//        public JAMK()
//        {
//            department.Name = "IT";
//        }

//        ~JAMK()
//        {
//            Console.WriteLine("JAMK is destructed");
//        }

//        public void PrintDepartmentName()
//        {
//            Console.WriteLine("JAMK Department name is " + department.Name);
//        }

//    }

//    class Department
//    {
//        public string Name { get; set; }
//        ~Department()
//        {
//            Console.WriteLine("Department " + Name + " is destructed");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            JAMK jamk = new JAMK();
//            jamk.PrintDepartmentName(); // prints: JAMK Department name is IT
//            jamk = null;

//            GC.Collect(); // prints: JAMK is destructed, Department IT is destructed

//            Console.ReadLine();
//        }
//    }
//}


// ESIMERKKI 7: Aggregation

//using System;

///* Aggregation is a special type of association
//   - Computer belongs to Classroom
//   - Classroom owns Computer. Computer can't belong to another parent object
//   - When Classroom dies, Computers may die ("Dell") or live on ("Hp")
//*/
//namespace Aggregation
//{

//    class Classroom
//    {
//        private Computer computer;

//        public Classroom()
//        {
//        }

//        public Classroom(Computer computer)
//        {
//            this.computer = computer;
//        }

//        ~Classroom()
//        {
//            Console.WriteLine("Classroom is destructed");
//        }

//        public void UseComputer()
//        {
//            Console.WriteLine("Classroom uses computer " + computer.Name);
//        }

//    }

//    class Computer
//    {
//        public string Name { get; set; }

//        public Computer(string name)
//        {
//            Name = name;
//        }

//        ~Computer()
//        {
//            Console.WriteLine("Computer " + Name + " is destructed");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Computer computer1 = new Computer("Hp");
//            Classroom classroom1 = new Classroom(computer1);
//            Classroom classroom2 = new Classroom(new Computer("Dell"));
//            classroom1 = null;
//            classroom2 = null;

//            GC.Collect(); //  Computer Dell is destructed, classroom1 is destructed,  classroom2 is destructed

//            Console.ReadLine();
//        }
//    }
//}



// ESIMERKKI 8: Aggregation

/* Aggregation is a special type of association
	 User owns Luser. Luser can't belong to another parent object
	 When User dies, Luser may die ("Yuri") or live on ("Arska")
*/

//using System;

//public class User
//{
//    private Luser lorppa;

//    public User()
//    {
//    }

//    public User(Luser luser)
//    {
//        lorppa = luser;
//    }

//    ~User()
//    {
//        Console.WriteLine("User is destructed");
//    }

//    public void PrintName()
//    {
//        Console.WriteLine("User uses luser " + lorppa.name);
//    }

//}

//public class Luser
//{
//    public string name;

//    public Luser(string name)
//    {
//        this.name = name;
//    }

//    ~Luser()
//    {
//        Console.WriteLine("Luser " + this.name + " is destructed");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Luser luser = new Luser("Arska");
//        User user1 = new User(luser);
//        User user2 = new User(new Luser("Yuri"));
//        user1 = null;
//        user2 = null;
//        GC.Collect(); //  User is destructed,  User is destructed, User Yuri is destructed
//        Console.ReadLine();
//        // Luser Arska is destructed
//    }
//}

//ESIMERKKI 8: List

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // create a list for integers
//        List<int> list = new List<int>();
//        // boolean variable, just check for looping
//        bool result;

//        // ask numbers
//        do
//        {
//            // ask number from the user (read one line)
//            Console.Write("Give a number > ");
//            string line = Console.ReadLine();
//            // try to read number from the given line
//            int number;
//            result = int.TryParse(line, out number);
//            // number (integer) was given correctly, use it..
//            if (result)
//            {
//                list.Add(number);
//            }
//        } while (result);

//        // write some statistics
//        Console.WriteLine("Average : {0}", list.Average());
//        Console.WriteLine("Min : {0}", list.Min());
//        Console.WriteLine("Max : {0}", list.Max());
//        Console.WriteLine("Numbers count : {0}", list.Count);

//        // all
//        foreach (int number in list)
//        {
//            Console.Write(number + ",");
//        }

//        // all with delegates
//        list.ForEach(item => Console.Write(item + ","));

//        // sort
//        list.Sort();

//        // all
//        Console.WriteLine();
//        list.ForEach(item => Console.Write(item + ","));

//        // read line to keep writelines visible
//        Console.ReadLine();
//    }
//}


//ESIMERKKI 9: List
//class Person
//{
//    public string Firstname { get; set; }
//    public string Lastname { get; set; }
//    public string SocialSecurityNumber { get; set; }

//    public override string ToString()
//    {
//        return Firstname + " " + Lastname + " " + SocialSecurityNumber;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // create a list for persons
//        List<Person> persons = new List<Person>();

//        // add persons to list
//        persons.Add(new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" });
//        persons.Add(new Person { Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "020292-222A" });
//        persons.Add(new Person { Firstname = "Teppo", Lastname = "Vuolle", SocialSecurityNumber = "030393-333A" });

//        // show one person data
//        Console.WriteLine(persons.ElementAt(0).ToString()); // Kirsi Mainio 010190-111A

//        // loop through all the persons
//        foreach (Person person in persons)
//        {
//            Console.WriteLine(person.ToString());
//        }
//        // outputs:
//        // Kirsi Mainio 010190 - 111A
//        // Matti Husso 020292 - 222A
//        // Teppo Vuolle 030393 - 333A
//    }
//}

    //ESIMERKKI 10: 