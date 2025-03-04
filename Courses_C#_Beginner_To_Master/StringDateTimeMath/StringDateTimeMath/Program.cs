using System.Text;

namespace StringDateTimeMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //string x = "Hello world";
            //Console.WriteLine(x);
            //string x1 = x.ToUpper();
            //Console.WriteLine(x1);
            //string x2 = x1.ToLower();
            //Console.WriteLine(x2);
            //string number = "123";
            //int number1 = int.Parse(number);
            //Console.WriteLine(number1);
            //int number2 = 234;
            //string x4 = number2.ToString();
            //Console.WriteLine(x4);
            //Console.WriteLine(string.IsNullOrEmpty(x4));
            //Console.WriteLine(string.IsNullOrWhiteSpace(x4));
            //string[] list = new string[] {
            //    "Number 1", "Number 2", "Hello world"
            //};
            //foreach(string s in list) {
            //    if(s.Contains("number"))
            //    {
            //        Console.WriteLine(s);
            //    }
            //    if(s.StartsWith("Number"))
            //    {
            //        Console.WriteLine(s);
            //    }
            //    if(s.EndsWith("world"))
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //string formated = string.Format("Hello ,{0}", x4);
            //Console.WriteLine(formated);
            //string replaceString = x4.Replace("234", "world");
            //Console.WriteLine(replaceString);
            //string trimString = x.Trim();
            //Console.WriteLine(trimString);
            //string[] list1 = x.Split(' ');
            //foreach(string s in list1)
            //{
            //    Console.WriteLine(s);
            //}
            //string subString = x.Substring(0, 5);
            //Console.WriteLine(subString);
            #endregion

            #region StringBuilder
            //StringBuilder x = new StringBuilder();
            //x.Append("Hello OriginalNVK");
            //x.Insert(5, ',');
            //x.Replace("Hello", "Master");
            //Console.WriteLine(x);
            #endregion

            #region DateTime
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString());
            //string x = now.ToString("yyyy-MM-dd HH:mm:ss");
            //Console.WriteLine(x);
            //DateTime date1 = new DateTime(2025, 1, 16);
            //DateTime date2 = new DateTime(2025, 2, 11);
            //TimeSpan space = date2 - date1;
            //Console.WriteLine(space.Days);
            //DateTime nextDate = now.AddDays(1);
            //Console.WriteLine(nextDate.ToString());
            //DateTime nextMonth = now.AddMonths(1);
            //Console.WriteLine(nextMonth.ToString());    
            //DateTime nextYear = now.AddYears(1);   
            //Console.WriteLine(nextYear.ToString());
            //string x2 = now.ToString("yyyy/MM/dd HH:mm:ss");
            //Console.WriteLine(x2);
            //Console.WriteLine(now.Day);
            #endregion

            #region Math
            //double sq = Math.Sqrt(5);
            //Console.WriteLine(sq);
            //double powResult = Math.Pow(4, 3);
            //Console.WriteLine(powResult);
            //double abs = Math.Abs(-sq);
            //Console.WriteLine(abs);
            //double number = Math.Round(sq, 2);
            //Console.WriteLine(number);
            //double ceil = Math.Ceiling(sq);
            //Console.WriteLine(ceil);
            //double floor = Math.Floor(sq);
            //Console.WriteLine(floor);
            #endregion

            #region exxpression

            #endregion
        }
    }
}
