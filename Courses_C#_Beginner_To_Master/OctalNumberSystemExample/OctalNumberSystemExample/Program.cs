namespace OctalNumberSystemExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dec1 = 340;
            string oct1 = Convert.ToString(dec1, 8);
            Console.WriteLine(oct1);
            int dec2 = Convert.ToInt32(oct1, 8);
            Console.WriteLine(dec2);
        }
    }
}
