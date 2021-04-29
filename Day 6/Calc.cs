using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        public static Tuple<double, double,double,double> Calc(double a, double b)
        {
            return new Tuple<double, double, double,double>((a + b), (a * b),(a-b),(a/b));
        }
        static void Main(string[] args)
        {
            Tuple<double, double,double,double> output = Program.Calc(8.0, 2.0);
            Console.WriteLine("Sum = \t" + output.Item1 + "\nMultiplication Value = \t" + output.Item2 +"\nSubtraction Value = \t" + output.Item3 +"\nDivision Value = \t"+ output.Item4);
            Console.ReadLine();
        }
    }
}
