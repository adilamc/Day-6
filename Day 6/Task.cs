using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;


namespace Day_6
{
    class Class6
    {
        public static void Main()
        {
            BlockingCollection<int> vs = new BlockingCollection<int>();
            Task.Run(() =>
            {
                while (!vs.IsCompleted)
                {
                    int x = 0;
                    try
                    {
                        x = vs.Take();
                    }
                    catch (InvalidOperationException)
                    {

                    }
                    if (x != 0)
                    {
                        //process x
                    }
                }
            });
            Task.Run(() => { 
            while ()
            {
                int x = 0;
                vs.Add(x);
            }
            vs.CompleteAdding();
        });
            Console.ReadLine();
        }
    }
}
