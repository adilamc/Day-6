using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Collection
    {
        public static void Main()
        {
            List<int> mylist = new List<int>();
            for(int i=0; i<10; i++)
            {
                mylist.Add(i * 2);
            }
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
