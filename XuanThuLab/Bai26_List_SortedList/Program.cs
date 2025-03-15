using System;
using System.Collections.Generic;

namespace Bai26
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int ID { get; set; }

        public string Origin { get; set; }

    }
    class Program
    {
        // List: 
        // SortedList: Map - C++
        static void Main(string[] args)
        {
            // List<int> ds1 = new List<int>()
            // {
            //     2, 3, 4, 5
            // };

            // ds1.Add(1);
            // ds1.AddRange(new int[] { 2, 3, 4, 5 });
            // Console.WriteLine(ds1.Count);
            // List<string> ds2;
            // ds1.Insert(0, 10);
            // Console.WriteLine(ds1[0]);
            // foreach (var item in ds1)
            // {
            //     Console.WriteLine(item);
            // }

            // ds1.RemoveAt(2);
            // ds1.Remove(9);
            // ds1.Add(9);
            // ds1.Add(9);
            // ds1.Remove(9); // Chi xoa di phan tu dau tien ma no tim thay
            // List<Product> products = new List<Product>()
            // {
            //     new Product() { ID = 1, Name = "Iphone 12", Origin = "USA", Price = 1000 },
            //     new Product() { ID = 2, Name = "Iphone 11", Origin = "Japan", Price = 900 },
            //     new Product() { ID = 3, Name = "Iphone 10", Origin = "USA", Price = 800 },
            //     new Product() { ID = 4, Name = "Iphone 9", Origin = "China", Price = 700 },
            //     new Product() { ID = 5, Name = "Iphone 8", Origin = "USA", Price = 600 },
            // };

            // Product? product1 = products.Find(p => p.Origin == "Japan");

            // Console.WriteLine(product1.Name);
            // products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            // foreach (var item in products)
            // {
            //     Console.WriteLine(item.Name);
            // }

            // Sorted List
            SortedList<string, Product> products = new SortedList<string, Product>();

            products["sanpham1"] = new Product() { ID = 1, Name = "Iphone 12", Origin = "USA", Price = 1000 };
            products.Add("sanpham2", new Product() { ID = 2, Name = "Iphone 11", Origin = "Japan", Price = 900 });
            var product = products["sanpham1"];
            Console.WriteLine(product.Name);

            // var keys = products.Keys;
            // var values = products.Values;
            // foreach (var item in keys)
            // {
            //     Console.WriteLine(products[item].Name);
            // }
            foreach (KeyValuePair<string, Product> item in products)
            {
                Console.WriteLine(item.Value.Name);
            }
        }
    }
}