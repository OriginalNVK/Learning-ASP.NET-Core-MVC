using System;

class Program
{
    static void Main()
    {
        Catagory catagory = new Catagory(20, "General");

        Console.WriteLine(catagory.ID);
        Console.WriteLine(catagory.Name);
        Console.WriteLine(catagory.GetCatagoryNameLength());

        Console.ReadKey();
    }
}