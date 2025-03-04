using System;

namespace Exercise_5
{
    internal class Program
    {
        static void WriteVariable(long x) // Chuyển WriteVariable thành static để có thể gọi từ phương thức Main
        {
            if (x != 0)
            {
                Console.Write(x);
            }
        }

        static void Main(string[] args)
        {
            long seconds = 3451545421;
            long year = seconds / 31536000;
            seconds -= year * 31536000;
            long month = seconds / 2592000;
            seconds -= month * 2592000;
            long day = seconds / 86400;
            seconds -= day * 86400;
            long hour = seconds / 3600;
            seconds -= hour * 3600;
            long minute = seconds / 60;
            seconds -= minute * 60;
            Console.Write("Year: ");
            WriteVariable(year);
            Console.Write(" Month: ");
            WriteVariable(month);
            Console.Write(" Day: ");
            WriteVariable(day);
            Console.Write(" Hour: ");
            WriteVariable(hour);
            Console.Write(" Minute: ");
            WriteVariable(minute);
            Console.Write(" Second: ");
            WriteVariable(seconds);
            Console.ReadKey();
        }
    }
}
