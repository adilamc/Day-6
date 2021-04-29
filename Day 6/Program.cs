using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        public static Tuple<double,double> AddMulti(double a, double b)
        {
            return new Tuple<double, double>((a + b), (a * b));
        }
        static void Main(string[] args)
        {
            Tuple<double, double> output = Program.AddMulti(3.5, 2.0);
            Console.WriteLine("Sum = " + output.Item1 + "Multiplication Value" + output.Item2);
            Console.ReadLine();
        }
    }
}
