using System;

namespace namespace1
{
    class Person
    {
        public int? NoOfChildren;
        public Nullable<int> _age;
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person() { NoOfChildren = 10 };
            Person person2 = new Person() { NoOfChildren = null };
            person1._age = 20;
            person2._age = 30;

            Person person3 = null;
            person3 = person1;
            if(person3.NoOfChildren.HasValue)
            {
                Console.WriteLine("yeah");
            }    
            Console.WriteLine(person1.NoOfChildren);
            Console.WriteLine(person1._age);
            Console.WriteLine(person2.NoOfChildren);
            Console.WriteLine(person2._age);
            Console.ReadKey();
        }
    }
}