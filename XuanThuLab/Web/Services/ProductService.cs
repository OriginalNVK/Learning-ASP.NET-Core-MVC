public class Product
{
    public string ID { get; set; }

    public string Name { get; set; }

    public double Price { get; set; }


}

public class ProductService
{
    List<Product> products = new List<Product>();
    public ProductService()
    {
        products.Add(new Product { ID = "1", Name = "Product 1", Price = 100 });
        products.Add(new Product { ID = "2", Name = "Product 2", Price = 200 });
        products.Add(new Product { ID = "3", Name = "Product 3", Price = 300 });
    }

    public Product FindProduct(string ProductId)
    {
        return products.FirstOrDefault(p => p.ID == ProductId);
    }
}