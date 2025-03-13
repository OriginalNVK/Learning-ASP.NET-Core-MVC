using System;
using MyNameSpace;
using Xyz = MyNameSpace.namespaceCon;
using static System.Console;
using static System.Math;

namespace Bai15_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1.XinChao();

            // Xyz.Class1.XinChao();

            // WriteLine(Sqrt(9));
            // WriteLine(PI);
            Product.Product product = new Product.Product();

            product.name = "Laptop";
            product.price = 1000;
            product.getInfo();
            product.description = "Laptop is very good";
            product.ShowAllInfo();
            product.manufactory = new Product.Product.Manufactory();
            product.manufactory.name = "Dell";
        }
    }
}