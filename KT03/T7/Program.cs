using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            CD MMLP = new CD();
            MMLP.Artist = "Eminem";
            MMLP.Name = "The Marshall Mathers LP";
            MMLP.Genre = "Rap";
            MMLP.Price = 19.99;
            MMLP.AddSongs();
            MMLP.PrintData();
        }
    }
}
