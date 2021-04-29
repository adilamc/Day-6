using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_3
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, int> rep = new Dictionary<char, int>();
            Console.Write("Enter a String : ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                int count = 0;
                foreach (char c in word)
                {
                    if (c == word[i])
                    {
                        count++;
                    }
                }
                if (!rep.ContainsKey(word[i]))
                {
                    rep.Add(word[i], count);
                }
            }
            foreach (var item in rep)
            {
                Console.WriteLine("Key = " + item.Key + "; Value = " + item.Value);
            }

            Console.ReadLine();

        }
    }
}
