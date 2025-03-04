using System;

class Program
{
    static void Main()
    {
        MarksPrinter<GraduateStudent> temp = new MarksPrinter<GraduateStudent>();
        temp.stu = new GraduateStudent();
        temp.stu.Marks = 10;
        temp.PrintMark();
        Console.ReadKey();

    }
}