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
            for (int i = 0; i < 5; i++)
            {
                int x =Convert.ToInt32(Console.ReadLine());
                mylist.Add(x);
            }
            foreach (var item in mylist)
            {
                if(item% 2 ==0)
                {
                    Console.WriteLine(item + "is even number");
                }
                else
                {
                    Console.WriteLine(item + "is odd number");
                }
                
            }
            Console.ReadLine();
        }
    }
}
