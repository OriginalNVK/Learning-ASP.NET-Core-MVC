using System;

public class Student
{
    public int Marks;
}

public class Employee
{
    public int salary;
}

public class Sample
{
    public void check<T>(T obj)
    {
        if (obj.GetType() == typeof(Student))
        {
            Student temp = obj as Student;
            Console.WriteLine(temp.Marks);
        }
        else if (obj.GetType() == typeof(Employee))
        {
            Employee temp = obj as Employee;
            Console.WriteLine(temp.salary);
        }
    }
}    