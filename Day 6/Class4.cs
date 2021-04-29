using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Class3
    {
        public static void Main()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Adila");
            keyValuePairs.Add(2, "Vysakh");
            keyValuePairs.Add(3, "Anees");
            Console.WriteLine(keyValuePairs[1]);
            foreach(var item in keyValuePairs)
            {
                Console.WriteLine("Key= "+ item.Key +"Value="+ item.Value);
            }
            if (keyValuePairs.ContainsKey(4) == true)
            {
                Console.WriteLine("Key Found");
            }
            else
            {
                Console.WriteLine("Key not Found");
            }
            if (keyValuePairs.ContainsValue("Adila"))
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value not Found");
            }
            Console.ReadLine();
        }
    }
}
