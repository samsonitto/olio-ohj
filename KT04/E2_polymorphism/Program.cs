using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_polymorphism
{
    class Animal
    {
        public virtual int Legs
        {
            get
            {
                return 0;
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine("Talk!");
        }
    }

    class Dog : Animal
    {
        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Wuw!");
        }
    }

    class Cat : Animal
    {
        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Miau!");
        }
    }

    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("CotCot!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //// Polymorphism
            //Animal animal1 = new Dog();
            //animal1.Talk(); // Wuw!
            //Console.WriteLine("animal1 has {0} legs.", animal1.Legs); // animal1 has 4 legs.
            //Console.WriteLine("animal1 type is {0}.", animal1.GetType()); // animal1 type is PolymorphismApplication.Dog

            //// Polymorphism
            //Animal animal2 = new Cat();
            //animal2.Talk(); // Miaum!
            //Console.WriteLine("animal2 has {0} legs.", animal2.Legs); // animal2 has 4 legs.
            //Console.WriteLine("animal2 type is {0}.", animal2.GetType()); // animal2 type is PolymorphismApplication.Cat

            // Polymorphism
            Animal animal3 = new Chicken();
            animal3.Talk(); // CotCot!
            Console.WriteLine("animal3 has {0} legs.", animal3.Legs); // animal3 has 2 legs.
            Console.WriteLine("animal3 type is {0}.", animal3.GetType()); // animal3 type is PolymorphismApplication.Chicken
        }
    }
}
