using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6___zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.AddProduct(new Product("Product 1", 5));
            box.AddProduct(new Product("Product 2", 10));

            IAbstractIterator iterator = box.GetIterator();
            while (iterator.IsDone != true)
            {
                Console.WriteLine(iterator.Current.ToString());
                iterator.Next();
            }
        }
    }
}