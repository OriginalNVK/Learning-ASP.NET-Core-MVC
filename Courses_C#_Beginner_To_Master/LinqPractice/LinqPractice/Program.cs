using System.Net.Cache;
using System.Security.Cryptography;

namespace LinqPractice
{
    internal class Program
    {
        public class Student{
            public int Id { get; set; }
            public string Name { get; set; }

            public int Age { get; set; }
        } 
        static void Main(string[] args)
        {
            #region Easy
            #region BT1
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] EvenNumber = numbers.Where(n => n % 2 == 0).ToArray();
            //foreach(int x in EvenNumber)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region BT2
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int minNumber = numbers.Min();
            //int maxNumber = numbers.Max();
            //Console.WriteLine(minNumber);
            //Console.WriteLine(maxNumber);
            #endregion

            #region BT3
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var numberLargerThan5 = Numbers.Where(n => n > 5).ToArray().Length;
            //Console.WriteLine(numberLargerThan5);
            #endregion

            #region BT4
            //int[] numbers = { 9, 9, 9 };
            //int first = numbers.FirstOrDefault(n => n >= 3);
            //int second = numbers.LastOrDefault(n => n < 8);
            //if (first == 0)
            //    Console.WriteLine("The first number in array is smaller than 3");
            //else Console.WriteLine(first);
            //if (second == 0)
            //    Console.WriteLine("The second number in array is larger than 8");
            //else Console.WriteLine(second);
            #endregion

            #region BT5
            //int[] numbers = { 4, 1, 3, 2 };
            //var listAfterSort = numbers.OrderBy(x => x);
            //foreach(var number in listAfterSort)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #endregion

            #region Medium
            #region BT5
            //string[] words = { "apple", "banana", "cherry", "avocado", "blueberry" };
            //var wordBeginWithA = words.Where(w => w.StartsWith("a"));
            //foreach(var word in wordBeginWithA)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region BT6
            //int[] numbers = { 1, 2, 3 };
            //int[] number2 = numbers.Select(x => x*x).ToArray();
            //foreach(int number in number2) { 
            //    Console.WriteLine(number);
            //}
            #endregion

            #region BT7
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numberOddIndex = numbers.Where(n =>Index(n) % 2 == 1).ToArray();  

            #endregion

            #region BT8
            //var students = new List<Student> {
            //    new Student { Id = 1, Name = "John", Age = 18 },
            //    new Student { Id = 2, Name = "Jane", Age = 20 },
            //    new Student { Id = 3, Name = "Tom", Age = 19 },
            //    new Student { Id = 4, Name = "Anna", Age = 22 }
            //};

            //var students2 = students.Where(s => s.Age > 19).Select(s => s.Name).ToList();
            //foreach(string student in students2)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region BT9
            //var students = new List<Student> {
            //    new Student { Id = 1, Name = "John", Age = 18 },
            //    new Student { Id = 2, Name = "Jane", Age = 20 },
            //    new Student { Id = 3, Name = "Tom", Age = 19 },
            //    new Student { Id = 4, Name = "Anna", Age = 22 }
            //};

            //var averageAge = (double)students.Sum(student => student.Age) / students.Count();
            //Console.WriteLine(averageAge);
            #endregion
            #endregion

            #region Hard

            #endregion
        }
    }
}
