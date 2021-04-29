using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class2
    {
        public static void Main()
        {
            Queue myqueue = new Queue();
            myqueue.Enqueue("c#");
            myqueue.Enqueue("PHP");
            myqueue.Enqueue("Java");
            myqueue.Enqueue("C");
            Console.WriteLine(myqueue.Count);
            Console.WriteLine(myqueue.Peek());
            foreach(var item in myqueue.ToArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
