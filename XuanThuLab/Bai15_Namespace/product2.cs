namespace Product
{
    public partial class Product
    {
        public string? description { get; set; }
        public Manufactory manufactory { get; set; }
        
        public class Manufactory
        {
            public string? name;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, Description: {description}");
        }
    }
}