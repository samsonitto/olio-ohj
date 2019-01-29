using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask number from the user (read one line)
            while (true)
            {
                Console.Write("Give a number > ");
                Check.OnkoLuku(Console.ReadLine());

                Console.Write("Give a date > ");
                Check.OnkoPvm(Console.ReadLine());
            }
        }
    }

    class Check
    {
        public static bool OnkoLuku(string input)
        {

            //bool result;
            if (double.TryParse(input, out double number) /*|| decimal.TryParse(input, out decimal deciNum)*/ && input[0] != ',' && input[input.Length - 1] != ',')
            {
                Console.WriteLine("The input {0} is number: True", input);
                return true;
            }

            else
            {
                Console.WriteLine("The input {0} is number: False", input);
                return false;
            }
        }

        public static bool OnkoPvm(string pvm)
        {
            CultureInfo myCIintl = new CultureInfo("fi-FI");

            if (pvm[1] != '.' && pvm[2] != '.')
            {
                for (int i = 0; i < pvm.Length; i++)
                {
                    int x = Convert.ToInt32(pvm[i]);

                    if (x < 48)
                    {
                        Console.WriteLine("Wrong separator!");
                        return false;
                    }
                }
            }
            if (pvm[2] == '.')
            {
                int a = Convert.ToInt32(pvm[3]);
                if (a == 49)
                {
                    int b = Convert.ToInt32(pvm[4]);
                    if (b > 50)
                    {
                        Console.WriteLine("Wrong month!");
                        return false;
                    }

                }
            }

            if (pvm[1] == '.')
            {
                int a = Convert.ToInt32(pvm[2]);
                if (a == 49)
                {
                    int b = Convert.ToInt32(pvm[3]);
                    if (b > 50)
                    {
                        Console.WriteLine("Wrong month!");
                        return false;
                    }
                }
            }



            if (DateTime.TryParse(pvm, out DateTime date))
            {
                //String.Format("{0:dd.mm.yy}", "{0:dd.mm.yyyy}", date);
                ////String.Format("{0:dd.mm.yyyy}", date);
                Console.WriteLine("True");
                return true;
            }

            else
            {
                Console.WriteLine("The date {0} is incorrect", pvm);
                return false;
            }
            
        }
    }
}
