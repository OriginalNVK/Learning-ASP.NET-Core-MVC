using System;

namespace ClassLibrary1
{
    public class Student
    {
        public double SecuredMarks;
        public double MaxMarks;
        public double Percentage;
    }

    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            CalculateHelper ch= new CalculateHelper();
            s.Percentage = ch.Multiply(s.SecuredMarks/s.MaxMarks, 100);
            Console.WriteLine(s.Percentage);
        }

        public class CalculateHelper
        {
            public double Multiply(double x1, double x2)
            {
                return x1 * x2;
            }
        }
    }
}
