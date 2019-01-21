using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T11
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 0;
            List<Results> r = new List<Results>();  // uusi taulukko, joka pohjautuu Results-luokkaan

            while (caseSwitch!=6) // Ohjelma pyˆrii siihen asti kun k‰ytt‰j‰ painaa valikossa "6"
            {

                // VALIKKO
                Console.WriteLine(@"-----------------------");
                Console.WriteLine(@"PERSONAL FIFA DATABASE |");
                Console.WriteLine(@"-----------------------");
                Console.WriteLine("1. Add result");
                Console.WriteLine("2. Show today's results");
                Console.WriteLine("3. Show the latest result");
                Console.WriteLine("4. Save to file");
                Console.WriteLine("5. Import from file");
                Console.WriteLine("6. Exit");

                Console.Write("Your choise > ");
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Player tag, your score, opponent's score: ");
                        r.Add(new Results() { OpponentName = Console.ReadLine(), MyScore = int.Parse(Console.ReadLine()), OpScore = int.Parse(Console.ReadLine()) });
                        //listCounter++;
                        Console.Clear();
                        break;
                        
                    case 2: // tulostaa kaikki tulokset
                        Console.WriteLine();
                        Console.Clear();
                        foreach (Results aResult in r) 
                        {
                            Console.WriteLine(aResult);
                        }
                        break;
                    case 3: // tulostaa viimeisimman tuloksen
                        Console.Clear();
                        var last = r[r.Count - 1];
                        Console.WriteLine(last);
                        break;
                    case 4: // tallentaa tiedostoon
                        WriteCSV(r, @"G:\Olio\KT02\T11\fifa.csv");
                        Console.Clear();
                        Console.WriteLine("Saved");
                        Console.WriteLine();
                        break;
                    case 5:  // tuo tiedostosta
                        var lines = System.IO.File.ReadAllLines("G:\\Olio\\KT02\\T11\\fifa.csv").Skip(1); // var-tyyppinen lines muuttuja on kaikki csv:n rivit, paitsi ylin rivi

                        foreach (string item in lines) 
                        {
                            var values = item.Split(','); // pilkkoo rivin

                            r.Add(new Results() // lis‰‰ r taulukkoon tiedot
                            {
                                OpponentName = values[0],
                                MyScore = int.Parse(values[1]),
                                OpScore = int.Parse(values[2])
                            });
                        }
                        Console.Clear();
                        Console.WriteLine("Databae loaded");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static void WriteCSV<T>(IEnumerable<T> items, string path) // csv:hen tallennus aliohjelma, ei mit‰‰n hajua miten toimii
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                        //        .OrderBy(p => p.Name);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }


    }
}
