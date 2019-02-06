using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    [Serializable]
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person henkilo = new Person { Firstname = "Pekka", Lastname = "Pouta"};

            Stream ws = new FileStream("henk.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(ws, henkilo);

            ws.Close();

            Stream rs = new FileStream("henk.bin", FileMode.Open, FileAccess.Read, FileShare.None);

            Person uusiHenk = (Person)formatter.Deserialize(rs);

            Console.WriteLine(uusiHenk.Firstname + " " + uusiHenk.Lastname);
        }
    }
}
