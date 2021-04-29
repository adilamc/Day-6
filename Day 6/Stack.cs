using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Stack
    {
        public static void Main()
        {
            //LIFO
            Stack<string> vs = new Stack<string>();
            vs.Push("Adila");
            vs.Push("MC");
            foreach(var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
