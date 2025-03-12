using System;

namespace Bai10_Class
{
    class Student : IDisposable
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Student object is created");
            
        }

        ~Student()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student object is destroyed");
            Console.ResetColor();
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student object is destroyed");
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Test()
        {
            using Student student = new Student("Sinh vien 01");
            Console.WriteLine("Do something");
            Console.WriteLine("Do something");
            Console.WriteLine("Do something");
        }
        static void Main(string[] args)
        {
            // VuKhi vk = new VuKhi();

            // VuKhi vk2 = new VuKhi("Xin Chaooooo");

            // Console.WriteLine(vk.name);
            // vk.ThietLapDoSatThuong(5);
            // vk.TanCong();
            // vk.SatThuong = 10;
            // Student student;
            // for (int i = 0; i < 100000; i++)
            // {
            //     student = new Student("SinhVien 1");
            // }

            // trong dotnet core hiện tại thì ko biết thời điểm nào thì hàm hủy được gọi vì lúc xưa nếu muốn thu hồi thì có thể thực hiện 
            // Để giải phóng bộ nhớ thì ta có thể sử dụng hàm Dispose
            // using (Student student = new Student("Sinh vien 1"))
            // {
            //     Console.WriteLine("Do something");
            // }
            // Console.ReadKey();
            Test();
        }
    }
}