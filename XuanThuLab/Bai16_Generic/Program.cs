using System;

namespace Bai16_generic
{
    // Generic la lop dai dien 
    public class Product<T>
    {
        public T? ID { get; set; }

        public void SetID(T ID)
        {
            this.ID = ID;
        }

        public void PrintInfo()
        {
            Console.WriteLine("ID: " + ID);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product<int> product1 = new Product<int>();
            product1.SetID(1);
            product1.PrintInfo();

            Product<string> product2 = new Product<string>();
            product2.SetID("Original NVK");
            product2.PrintInfo();
        }
    }
}