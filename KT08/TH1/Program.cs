using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1
{
    class Program
    {
        static void Kjal()
        {
            try
            {

                
                StreamWriter info = new StreamWriter("info.txt");
                string arvo;
                do
                {
                    Console.WriteLine("Anna nimi: (tyhjä lopettaa) ");
                    arvo = Console.ReadLine();
                    if (arvo.Length != 0)
                        info.WriteLine(arvo);
                }
                while (arvo.Length != 0);
                info.Close();

                Console.WriteLine("Henkilöt kirjoitettu tiedostoon!");
                string text = File.ReadAllText("info.txt");
                Console.WriteLine("Contents of info.txt: ");
                Console.WriteLine(text);
            }

            catch (Exception)
            {
                Console.WriteLine("jtn meni vituillee");
            }
            //for(int i = 0; i<5; i++)
            //{
            //    Console.Write("Give a text line (enter ends) : ");
            //    string nimi = Console.ReadLine();
            //    info.WriteLine(nimi);
            //}
            //info.Close();

            //string text = File.ReadAllText("info.txt");
            //Console.WriteLine("Contents of info.txt: ");
            //Console.WriteLine(text);


        }

        static void Main()
        {
            Kjal();
        }
    }
}
