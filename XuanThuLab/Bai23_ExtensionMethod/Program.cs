using System;
using MyLib;

namespace Bai23
{
    // extension method:
    static class Abc
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    } 
    class Program
    {

        static void Main()
        {
            // int[] mang = { 1, 2, 3, 4 };
            // int max = mang.Max();
            // Console.WriteLine("Max: " + max);
            // string s = "Xin chao cac ban";
            // s.Print(ConsoleColor.Blue);

            double a = 2.5;
            Console.WriteLine(a.BinhPhuong());
            Console.WriteLine(a.CanBac2());
            Console.WriteLine(a.Sin());
            Console.WriteLine(a.Cos());

        }
    }
}