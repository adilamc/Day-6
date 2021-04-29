using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductCode { get; set; }
        public Dictionary<string, List<int>> data { get; set; }
        public List<int> list { get; set; }
        public void InputDeatils()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            List<int> list = new List<int>();
            Console.WriteLine("Enter the no.of Products to be entered to the collection : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the Product Name : ");
                ProductName = Console.ReadLine();
                Console.Write("Enter the Quantity of the Product : ");
                Quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Price of the Product : ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the ProductCode of the Product : ");
                ProductCode = Convert.ToInt32(Console.ReadLine());
                list.Add(Quantity);
                list.Add(Price);
                list.Add(ProductCode);
                data.Add(ProductName, list); //adding each product to the dictionary
            }
            Console.WriteLine("INVOICE");
            Console.WriteLine("\n S.No \t\t Product Name \t\t Quantity \t\t Price \t\t ProductCode \t\t Total");
            int index = 1;
            foreach (var item in data)
            {
                Console.Write(index);
                Console.Write("\t\t");
                Console.Write(item.Key);
                Console.Write("\t\t\t\t");
                for(int i = 0; i < num; i++)
                {
                    Console.Write(Quantity);
                    Console.Write("\t\t");
                    Console.Write(Price);
                    Console.Write("\t\t");
                    Console.Write(ProductCode);
                    Console.Write("\t\t\t");
                    Console.Write(Quantity * Price);
                }
                
                Console.WriteLine();
                index = index + 1;
            }
        }
        public static void Main()
        {
            Product obj1 = new Product();
            obj1.InputDeatils();
            Console.ReadLine();
        }
    }
}
