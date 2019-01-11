using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give seconds > ");
            string input = Console.ReadLine();
            int sec;
            int.TryParse(input, out sec);
            int min = sec / 60;
            int hr = min / 60;
            int day = hr / 24;

            if (sec < 60)
            {
                Console.WriteLine(sec + " sec");
            }
            if (sec >= 60 && hr < 1)
            {
                sec = sec % 60;
                Console.WriteLine(min + " min " + sec + " sec");
            }
            if (min >= 60 && day < 1)
            {
                sec = sec % 60;
                min = min % 60;
                Console.WriteLine(hr + " hr " + min + " min " + sec + " sec");
            }
            if (hr >= 24 && day == 1)
            {
                sec = sec % 60;
                min = min % 60;
                hr = hr % 24;
                Console.WriteLine(day + " day " + hr + " hr " + min + " min " + sec + " sec");
            }
            if (hr >= 24 && day > 1)
            {
                sec = sec % 60;
                min = min % 60;
                hr = hr % 24;
                Console.WriteLine(day + " days " + hr + " hr " + min + " min " + sec + " sec");
            }
        }
    }
}
