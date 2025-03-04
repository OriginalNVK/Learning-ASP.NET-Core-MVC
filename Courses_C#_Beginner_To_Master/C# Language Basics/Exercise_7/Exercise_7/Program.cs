using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 50;
            int num3 = 123;
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }    
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
