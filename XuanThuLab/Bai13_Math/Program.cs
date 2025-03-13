using System;

namespace Bai13_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hang so Pi: {0}", Math.PI);
            // Console.WriteLine("Hang so E: {0}", Math.E);
            // Console.WriteLine("So lon nhat trong 2 so la: {0}", Math.Max(5, 10));
            // Console.WriteLine("So nho nhat trong 2 so la: {0}", Math.Min(5, 10));

            // Abs, sign
            // Console.WriteLine("Gia tri tuyet doi cua -10 la: {0}", Math.Abs(-10));

            // Luong gia
            // Sin, cos, tan, Asin, Acos, Atan, Sinh, Cosh, Tanh
            // Console.WriteLine("Sin pi/2 la: {0}", Math.Sin(Math.PI / 2));


            // Can bac 2, luy thua, logarit
            // Console.WriteLine($"Can bac 2 cua 2: {Math.Sqrt(2)}");
            // Console.WriteLine($"Gia tri 2^3: {Math.Pow(2, 3)}");
            // Console.WriteLine($"Logarit co so e cua 5: {Math.Log(5)}");

            // Lam tron
            // Math.Round(5.6)  // 6; Math.Round(5.4)  // 5
            // Math.Ceiling(5.1) :6; Lam tron len
            // Math.Floor(5.9) : 5 Lam tron xuong
            // Truncate: Cat bo phan thap phan
            // Console.WriteLine($"Lam tron 5.6: {Math.Round(5.6)}");
            Console.WriteLine($"Ceiling: {Math.Ceiling(5.1)}");
            Console.WriteLine($"Floor: {Math.Floor(5.9)}");
            Console.WriteLine($"Truncate: {Math.Truncate(5.9)}");
        }
    }
}