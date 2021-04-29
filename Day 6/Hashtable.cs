using System;
using System.Collections;


namespace Day_6
{
    class Class6
    {
        public static void Main()
        {
            Hashtable g = new Hashtable();
            g.Add(1,"Welcome");
            g.Add(2,"to");
            g.Add(3,"C Sharp");
            g.Add(4,"Class");
            ICollection key = g.Keys;
            foreach (var item in key)
            {
                
                Console.WriteLine(item +"-"+ g[item]);
            }
            Console.ReadLine();
        }
    }
}
