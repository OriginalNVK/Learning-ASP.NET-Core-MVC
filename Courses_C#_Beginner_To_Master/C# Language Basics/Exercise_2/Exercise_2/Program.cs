using System;
using System.Net.NetworkInformation;

namespace Exercise_2
{
    internal class Program
    {
        const float pi = 3.14159f;
        static void Main(string[] args)
        {
            float radius = 3f;
            float area = pi * radius * radius;
            Console.WriteLine("Area of Circle: " +  area);
        }
    }
}
