using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            TV lg = new TV();
            lg.Model = "LG";
            lg.SetPower();
            lg.CheckPower();
            lg.ChUp();
            lg.ChUp();
            lg.ChUp();
            lg.ChUp();
            lg.ChUp();
            lg.ChDown();
            lg.ChDown();
            Console.WriteLine();
            lg.PrintData();

            TV sony = new TV();
            sony.Model = "SONY";
            sony.SetPower();
            sony.CheckPower();
            sony.ChUp();
            sony.ChUp();
            sony.ChUp();
            sony.ChDown();
            sony.ChUp();
            sony.ChDown();
            sony.ChDown();
            Console.WriteLine();
            sony.PrintData();

            TV samsung = new TV();
            samsung.Model = "Samsung";
            samsung.SetPower();
            samsung.CheckPower();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChUp();
            samsung.ChDown();
            samsung.ChDown();
            Console.WriteLine();
            samsung.PrintData();

            TV panasonic = new TV();
            panasonic.Model = "Panasonic";
            panasonic.SetPower();
            panasonic.CheckPower();
            panasonic.ChInput();
            Console.WriteLine();
            panasonic.PrintData();
        }
    }
}
