using System;

namespace Anonymous_type
{
    internal class Program
    {
        static void Main()
        {
            #region Anonymous_Type
            //var student = new { fullName = "Nguyen Van Khanh", age = 20, sex = "male" };
            //var student2 = new { fullName = "Van Ho Phuong Ha", age = 20, sex = "female" };
            //bool yes = student.Equals(student2);
            //Console.WriteLine(yes);

            //Console.WriteLine(student.fullName);
            //Console.WriteLine(student.age);
            //Console.WriteLine(student.sex);
            #endregion

            #region Nested anonymous type

            //var book = new
            //{
            //    Title = "Toi Yeu Em",
            //    Author = new { Name = "Nguyen Van Khanh", Country = "VietNam" },
            //    Publisher = new { Name = "LoveBooks", Year = "2023" }
            //};
            //Console.WriteLine(book.Author.Name);

            //Console.WriteLine(book);
            #endregion

            #region Anonymous Array
            var students = new[]{
                new { name = "Nguyen Van Khanh", age = 20 },
                new { name = "Van Ho Phuong Ha", age = 20 },
                new { name = "Nguyen Van Quoc", age = 25 },
            };
            int count = 1;

            foreach (var student in students)
            {
                Console.WriteLine($"The person {count++}: ");
                Console.WriteLine("Name: " + student.name);
                Console.WriteLine("Age: " + student.age);
            }    
            #endregion
        }
    }
}
