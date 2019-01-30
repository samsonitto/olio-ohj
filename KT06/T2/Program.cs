using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Meat beef = new Meat();
            beef.Type = "Beef";
            beef.Weight = 400;
            beef.ExpDate = "11.2.2019";
            beef.Quantity = 2;

            Meat pork = new Meat();
            pork.Type = "pork";
            pork.Weight = 800;
            pork.ExpDate = "7.2.2019";
            pork.Quantity = 3;

            Veggies tomato = new Veggies();
            tomato.Type = "Tomato";
            tomato.Weight = 30;
            tomato.ExpDate = "1.2.2019";
            tomato.Color = "red";
            tomato.Quantity = 6;

            Veggies potato = new Veggies();
            potato.Type = "Potato";
            potato.Weight = 27;
            potato.ExpDate = "1.4.2019";
            potato.Color = "brown";
            potato.Quantity = 20;

            Drinks orangeJuice = new Drinks();
            orangeJuice.Type = "Orange juice";
            orangeJuice.Weight = 1000;
            orangeJuice.ExpDate = "1.2.2019";
            orangeJuice.AddedSugar = true;
            orangeJuice.Quantity = 1;

            Drinks milk = new Drinks();
            milk.Type = "Milk";
            milk.Weight = 1000;
            milk.ExpDate = "30.1.2019";
            milk.AddedSugar = false;
            milk.Quantity = 2;

            Fridge fridge = new Fridge();
            fridge.Name = "Samson's fridge";
            fridge.Model = "Samsung";
            fridge.Temperature = 3;

            for (int i = 0; i<beef.Quantity;i++ )
            {
                fridge.meats.Add(beef);
            }

            for (int i = 0; i < pork.Quantity; i++)
            {
                fridge.meats.Add(pork);
            }

            for (int i = 0; i < tomato.Quantity; i++)
            {
                fridge.veggies.Add(tomato);
            }

            for (int i = 0; i < potato.Quantity; i++)
            {
                fridge.veggies.Add(potato);
            }

            for (int i = 0; i < orangeJuice.Quantity; i++)
            {
                fridge.drinks.Add(orangeJuice);
            }

            for (int i = 0; i < milk.Quantity; i++)
            {
                fridge.drinks.Add(milk);
            }
            fridge.PrintData();

            
        }
    }

    public class Fridge
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Temperature { get; set; }

        public List<Meat> meats = new List<Meat>();
        public List<Veggies> veggies = new List<Veggies>();
        public List<Drinks> drinks = new List<Drinks>();

        public Fridge()
        {

        }

        public void PrintData()
        {
            Console.WriteLine("Fridge: {0} Model: {1} Temperature: {2}", Name, Model, Temperature);
            foreach (Meat meat in meats)
            {
                Console.WriteLine(meat.ToString());
            }

            Console.WriteLine("===================================");

            foreach (Veggies veggie in veggies)
            {
                Console.WriteLine(veggie.ToString());
            }

            Console.WriteLine("===================================");

            foreach (Drinks drink in drinks)
            {
                Console.WriteLine(drink.ToString());
            }

            Console.WriteLine("Total veggies: " + veggies.Capacity);


        }
    }

    public class Meat
    {
        public string Type { get; set; }
        public int Weight { get; set; }
        public string ExpDate { get; set; }
        public int Quantity { get; set; }

        public Meat()
        {

        }

        public override string ToString()
        {
            return " - Type: " + Type + ", weight: " + Weight + "g , expiration date: " + ExpDate;
        }
    }

    public class Veggies : Meat
    {
        public string Color { get; set; }

        public Veggies()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", color: " + Color;
        }
    }

    public class Drinks : Meat
    {
        public bool AddedSugar { get; set; }

        public Drinks()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ", added sugar: " + AddedSugar;
        }
    }
}
