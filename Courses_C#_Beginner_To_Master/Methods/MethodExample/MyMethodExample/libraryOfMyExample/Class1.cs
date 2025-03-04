public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    // constructor:
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();  
    }

    public void CalculateTax()
    {
        double t = 0;
        if(cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }
}