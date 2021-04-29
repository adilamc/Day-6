using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class7
    {
        public static void Main()
        {
            LinkedList<string> vs = new LinkedList<string>();
            vs.AddLast("Adila");
            vs.AddLast("MC");
            vs.AddLast("is");
            vs.AddLast("in");
            vs.AddLast("India");
            Console.WriteLine(vs.First.Value);
            Console.WriteLine(vs.Last.Value);
            Console.WriteLine(vs.Contains("India"));
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
