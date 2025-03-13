namespace Product
{
    public partial class Product
    {
        public string? name { get; set; }

        public double price { get; set; }

        public void getInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}");
        }
    }
}