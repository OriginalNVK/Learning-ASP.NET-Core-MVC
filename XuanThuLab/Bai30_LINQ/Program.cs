using System;
using System.Linq;

namespace Bai30
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }
    // LINQ: (Language Integrated Query): Ngon ngu truy van tich hop
    // Giong SQL
    // Nguon du lieu: INumerable, IEnumerable<T>
    // XML, SQL server, 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}