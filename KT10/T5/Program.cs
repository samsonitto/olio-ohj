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
            double[] arr = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            //double[] arr = { };


            Console.WriteLine("Sum = {0}", ArrayCalcs.Sum(arr));
            Console.WriteLine("Average = {0}", ArrayCalcs.Avg(arr));
            Console.WriteLine("Min = {0}", ArrayCalcs.Min(arr));
            Console.WriteLine("Max = {0}", ArrayCalcs.Max(arr));

        }
    }

    public class ArrayCalcs
    {
        //public static double[] Arr { get; set; }

        public static double Sum(double[] arr)
        {
            double sum = Math.Round(arr.Sum(), 2);
            return sum;
        }

        public static double Avg(double[] arr)
        {
            double avg = Math.Round(arr.Average(), 2);
            return avg;
        }

        public static double Max(double[] arr)
        {
            double max = arr.Max();
            return max;
        }

        public static double Min(double[] arr)
        {
            double min = arr.Min();
            return min;
        }
    }
}