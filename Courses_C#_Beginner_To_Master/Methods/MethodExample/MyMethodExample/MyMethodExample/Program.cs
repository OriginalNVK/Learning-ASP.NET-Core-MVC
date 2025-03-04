using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        const string developerName = "Nguyen Van Khanh";

        Product product1, product2, product3;
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;

        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        product2.productID = 1003;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;
        product3.productID = 1002;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        // call method
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        // get value
        Console.WriteLine("Product 1");
        Console.WriteLine("Product ID: " + product1.productID);
        Console.WriteLine("Product Name: " + product1.productName);
        Console.WriteLine("Cost: " + product1.cost);
        Console.WriteLine("Quantity in stock: " + product1.quantityInStock);
        Console.WriteLine("Date of purchase: " + product1.dateOfPurchase);
        Console.WriteLine("Tax: " + product1.tax);
        Console.WriteLine();

        // Product 2
        Console.WriteLine("Product 2");
        Console.WriteLine("Product ID: " + product2.productID);
        Console.WriteLine("Product Name: " + product2.productName);
        Console.WriteLine("Cost: " + product2.cost);
        Console.WriteLine("Quantity in stock: " + product2.quantityInStock);
        Console.WriteLine("Date of purchase: " + product2.dateOfPurchase);
        Console.WriteLine("Tax: " + product2.tax);
        Console.WriteLine();

        // Product 3
        Console.WriteLine("Product 3");
        Console.WriteLine("Product ID: " + product3.productID);
        Console.WriteLine("Product Name: " + product3.productName);
        Console.WriteLine("Cost: " + product3.cost);
        Console.WriteLine("Quantity in stock: " + product3.quantityInStock);
        Console.WriteLine("Date of purchase: " + product3.dateOfPurchase);
        Console.WriteLine("Tax: " + product3.tax);
        Console.WriteLine();

        // Total of store
        int totalQuantity = product1.quantityInStock + 
            product2.quantityInStock + 
            product3.quantityInStock;
        Console.WriteLine("Total quantity: " + totalQuantity);
        Console.WriteLine("Total no. Of Product: " + Product.TotalNoProducts);
        Console.WriteLine("Category of product: " + Product.CategoryName);
    }
}