using System;
using System.Collections;


namespace Day_6
{
    class Class6
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("3");
            arrayList.Add("a");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
