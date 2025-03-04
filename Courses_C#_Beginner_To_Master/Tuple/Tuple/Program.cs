using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Tuple2
{
    internal class Program
    {
        public static (string Title, string Author, int Pages) getBookInfor()
        {
            return ( "NVKPH", "Original NVK", 150);
        }

        public static (int min, int max) getMinMax(int[] array)
        {
            int min = array.Min();
            int max = array.Max();
            return (min, max);
        }
        static void Main(string[] args)
        {
            #region Easy
            #region BT1
            //var example = Tuple.Create(42, "Hello", true);
            //Console.WriteLine(example.Item1);
            //Console.WriteLine(example.Item2);
            //Console.WriteLine(example.Item3);
            #endregion

            #region BT2
            //var product = (ID: 1, ProductName: "Laptop dell G15", Price: 25000000);
            //Console.WriteLine(product.ID);
            //Console.WriteLine(product.ProductName);
            //Console.WriteLine(product.Price);
            #endregion

            #region BT3
            //var book = (Title: "NVKPH", Author: "Original NVK", Pages: 150);
            //Console.WriteLine(book.Title);
            //Console.WriteLine(book.Author);
            //Console.WriteLine(book.Pages);
            #endregion

            #region BT4
            //var Book = getBookInfor();
            //Console.WriteLine(Book.Title);
            //Console.WriteLine(Book.Author);
            //Console.WriteLine(Book.Pages);
            #endregion
            #endregion

            #region Medium
            #region BT1
            //var student = (StudentID: 1, FullName: "Nguyen Van Khanh", GPA: 9.0);
            //var (StudentID, FullName, gpa) = student;
            //Console.WriteLine(StudentID);
            //Console.WriteLine(FullName);
            //Console.WriteLine(gpa);
            #endregion

            #region BT2
            //var employee = (Id: 1, Name: "eNKay", Salary: 10000000, Department: "Develop Team");
            //var (ID,_, Salary, _) = employee;
            //Console.WriteLine(ID);
            //Console.WriteLine(Salary);
            #endregion

            #region BT3
            //int[] a = {1, 2, 3};
            //var result = getMinMax(a);
            //Console.WriteLine(result.min);
            //Console.WriteLine(result.max);
            #endregion

            #region BT4
            
            #endregion
            #endregion
        }
    }
}
