namespace Day1.Entities
{
    public class IProduct
    {
        public string? Name { get; set; }

        public double Price { get; set; }
    }

    public class Product : IProduct { 
        public int ID { get; set; }
    }
}
