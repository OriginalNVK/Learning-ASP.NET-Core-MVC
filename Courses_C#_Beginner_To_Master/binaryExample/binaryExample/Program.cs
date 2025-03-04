namespace binaryExample
{
    internal class Program
    {
        static void Main()
        {
            int dec1 = 304;
            string binary1 = Convert.ToString(dec1, 2);
            Console.WriteLine(binary1);
            int dec2 = Convert.ToInt32(binary1, 2);
            Console.WriteLine(dec2);
            int dec3 = 0b1101101;
            dec3 += 1;
            Console.WriteLine(dec3);
            Console.ReadKey();
        }
    }
}
