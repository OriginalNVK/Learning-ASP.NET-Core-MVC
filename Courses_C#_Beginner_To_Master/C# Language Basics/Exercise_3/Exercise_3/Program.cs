using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float heightInFeet = 5f;
            float heightInInch = 7f;
            float convertHeightFeetToCen = heightInFeet * 30.48f;
            float convertHeightInchToCen = heightInInch * 2.54f;
            Console.WriteLine("Height in feet after convert to centimeter: " + convertHeightFeetToCen);
            Console.WriteLine($"Height in inch after convert to centimeter: {convertHeightInchToCen}");
        }
    }
}
