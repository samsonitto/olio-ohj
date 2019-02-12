using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBook book = new MyBook();
            StreamReader tutut = new StreamReader("tutut.csv");
            tutut.Close();
            //StreamWriter sw = new StreamWriter("tutut.csv");
            List<Friend> friends = new List<Friend>();

            Console.WriteLine("Osoitekirjassa {0} nimeä:", File.ReadAllLines("tutut.csv").Count());
            foreach (string item in File.ReadAllLines("tutut.csv"))
            {
                var values = item.Split(';');
                friends.Add(new Friend() { Name = values[0]+";", Email = values[1]+";" });

                Console.WriteLine(values[0]);
            }

            int caseSwitch = 0;

            while (caseSwitch != 3)
            {

                Console.WriteLine(@"-------");
                Console.WriteLine(@"MyBook |");
                Console.WriteLine(@"-------");
                Console.WriteLine("1. Lisää tuttu");
                Console.WriteLine("2. Hae tuttu");
                Console.WriteLine("3. Sulje");

                Console.Write("Your choise > ");
                caseSwitch = int.Parse(Console.ReadLine());


                switch (caseSwitch)
                {
                    case 1:
                        Console.Write("Nimi > ");
                        string inputName = Console.ReadLine();

                        Console.Write("Email > ");
                        string inputEmail = Console.ReadLine();

                        friends.Add(new Friend()
                        {
                            Name = inputName + ";",
                            Email = inputEmail + ";"
                        });

                        StreamWriter sw = new StreamWriter("tutut.csv");
                        foreach (Friend item in friends)
                        {
                            sw.WriteLine(item);
                        }
                        sw.Close();
                        break;
                    case 2:

                        Console.Write("Anna haettavan tutun nimi tai sen alkuosa: ");
                        string input = Console.ReadLine();

                        foreach (string item in File.ReadAllLines("tutut.csv"))
                        {
                            var result = File.ReadAllLines("tutut.csv").Any(a => item.Contains(input));
                            if (result != false)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        break;

                }

            }
            
            

            
        }
    }

    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }

        

        public Friend()
        {

        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Email);
        }
    }

    public class MyBook
    {
        //public List<Friend> friends = new List<Friend>();



    
    }


}
