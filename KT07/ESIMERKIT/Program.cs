using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIMERKIT
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter s = new StreamWriter("esim.txt");
            s.WriteLine("lorppa");
            s.Close();

            string m = File.ReadAllText("esim.txt");
        }
    }
}
