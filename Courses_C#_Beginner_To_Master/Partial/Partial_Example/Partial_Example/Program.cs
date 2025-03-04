using static System.Console;
using Warehouse;
class Program
{
    static void Main()
    {
        Product product = new Product();
        product.ProductID = 101;
        product.Cost = 1000;

        product.CallGetTax();
    }
}