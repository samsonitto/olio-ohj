using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            List<Person> people = new List<Person>();
            Stopwatch stopWatch = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();

            int r;
            
            for (int i = 0; i < 10000; i++)
            {
                StringBuilder eNimi = new StringBuilder(4);
                for (int j = 0; j < 4; j++)
                {
                    r = ran.Next(25);
                    eNimi.Append(alphabet[r]);

                }

                StringBuilder sNimi = new StringBuilder(10);
                for (int j = 0; j < 10; j++)
                {
                    r = ran.Next(25);
                    sNimi.Append(alphabet[r]);
                }

                people.Add(new Person()
                {
                    Enimi = eNimi.ToString(),
                    Snimi = sNimi.ToString(),
                });



            }

            stopWatch.Start();
            foreach (Person item in people)
            {
                Console.WriteLine(item.ToString());
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = string.Format("{0} ms", ts.TotalMilliseconds);
            Console.WriteLine(elapsedTime);


            Console.WriteLine("Löydetty:");

            for (int y = 0; y < 1000; y++)
            {
                StringBuilder haku = new StringBuilder(4);
                for (int j = 0; j < 4; j++)
                {
                    r = ran.Next(25);
                    haku.Append(alphabet[r]);
                    
                }

                foreach (Person a in people)
                {
                    if(haku.ToString() == a.Enimi)
                    {
                        Console.WriteLine(haku + " " + a.Snimi);
                    }
                }
            }

            
        }


    }

    public class Person
    {
        public string Enimi { get; set; }
        public string Snimi { get; set; }

        public Person()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Enimi, Snimi);
        }
    }
}

