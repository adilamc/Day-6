using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Program
    {
        //public static Tuple<double, double, double, double> Calc(double a, double b)
        //{
        //    return new Tuple<double, double, double, double>((a + b), (a * b), (a - b), (a / b));
        //}
        static void Main(string[] args)
        {
            //Tuple<double, double, double, double> output = Program.Calc(8.0, 2.0);
            //Console.WriteLine("Sum = \t" + output.Item1 + "\nMultiplication Value = \t" + output.Item2 + "\nSubtraction Value = \t" + output.Item3 + "\nDivision Value = \t" + output.Item4);
            Tuple<int, int, int, int, int, int, int, int> tuple = new Tuple<int, int, int, int, int, int, int, int>(1,2,3,4,5,6,7,8);
            
            Console.WriteLine(tuple.Item1 + tuple.Item2 + tuple.Item3 + tuple.Item4 + tuple.Item5 + tuple.Item6 + tuple.Item7 + tuple.Rest);
            var tuple1 = Tuple.Create(1, 2, 3, 4, Tuple.Create(5, 6), 7, 8);
            Console.WriteLine(tuple1.Item1 + tuple1.Item2 + tuple1.Item3 + tuple1.Item4 + tuple1.Item5.Item1 + tuple1.Item5.Item2 + tuple.Item6 + tuple.Item7);
            Console.ReadLine();
        }
    }
}
