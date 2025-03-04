using ClassLibrary1;
using System;

namespace InnerClassExample
{
    internal class Program
    {
        static void Main()
        {
            Student s = new Student() { SecuredMarks = 35, MaxMarks = 50 };

            MarksCalculation mc = new MarksCalculation();
            MarksCalculation.CalculateHelper ch = new MarksCalculation.CalculateHelper();
            Console.WriteLine(ch.Multiply(s.MaxMarks, 100));
            mc.CalculatePercentage(s);        }
    }
}
