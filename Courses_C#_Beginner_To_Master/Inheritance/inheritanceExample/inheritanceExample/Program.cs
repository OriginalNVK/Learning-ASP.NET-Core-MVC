using System;

class Program
{
    static void Main()
    {
        // create object
        Manager emp2 = new Manager(102, "eNKay", "Dong Thap", "Sales apartment");
        // Xuat Emp2
        Console.WriteLine(emp2.EmpID);
        Console.WriteLine(emp2.EmpName);
        Console.WriteLine(emp2.Location);
        Console.WriteLine(emp2.departmentName);
        Console.WriteLine(emp2.GetHealthInsuranceAmount());
        Console.WriteLine();


        SalesMan emp3 = new SalesMan(103, "Tokuda", "TP. HCM", "North");
        // Xuat Emp2
        Console.WriteLine(emp3.EmpID);
        Console.WriteLine(emp3.EmpName);
        Console.WriteLine(emp3.Location);
        Console.WriteLine(emp3.Region);
        Console.WriteLine(emp3.GetHealthInsuranceAmount());
        Console.WriteLine(emp3.GetSalesOfTheCurrentMonth());
        Console.WriteLine();

        Console.ReadKey();
    }
}