using System;

namespace Exercese_4
{
    internal class Program
    {
        static int round(int x)
        {
            int result = (x < 500) ? 1000 : (x % 1000 < 500) ? x - x % 1000 : x - x % 1000 + 1000;
            return result;
        }
        static void Main(string[] args)
        {
            int number1 = 499;
            int number2 = 500;
            int number3 = 999;
            int number4 = 1499;
            int number5 = 1500;
            int resultNumber1 = round(number1);
            int resultNumber2 = round(number2);
            int resultNumber3 = round(number3);
            int resultNumber4 = round(number4);
            int resultNumber5 = round(number5);
            Console.WriteLine("Result of round number1: " +  resultNumber1);
            Console.WriteLine("Result of round number2: " + resultNumber2);
            Console.WriteLine("Result of round number3: " + resultNumber3);
            Console.WriteLine("Result of round number4: " + resultNumber4);
            Console.WriteLine("Result of round number5: " + resultNumber5);
        }
    }
}
