using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace T11
{
    class Results
    {
        public string OpponentName { get; set; }
        //public string Comment { get; set; }
        public int MyScore { get; set; }
        public int OpScore { get; set; }

        public override string ToString()
        {
            return "Vs. " + OpponentName + "   " + MyScore + " - " + OpScore;
        }

        

    }
}
