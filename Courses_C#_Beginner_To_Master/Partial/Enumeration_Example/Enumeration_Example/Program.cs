using System;
class Program
{
    static void Main()
    {
        Person person = new Person();
        person.PersonName = "Original NVK";
        person.Email = "NVK@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;
        Console.WriteLine(person.AgeGroup);
        Console.ReadKey();
    }
}