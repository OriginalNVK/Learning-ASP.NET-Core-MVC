using System;
using System.Text;

namespace Bai11_String_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // string thongBao;
            // thongBao = "\\Hoc ve \"chuoi\" \n";
            // string xinChao = @"Toi la \ Origi";
            // int year = 2025;
            // // Có thể chèn dấu $
            // thongBao = $"Xin chao {year}";
            // Console.WriteLine(thongBao);
            // // Có thể chèn một số khoảng trống nhất định vào chuỗi
            // thongBao = $"Xin chao {year, 10}"; // Căn lề phải và chừa 10 ký tự sau chuỗi xin chào
            // Console.WriteLine(thongBao);
            // // Muốn căn lề trái thì 
            // thongBao = $"Xin chao {year, -10}"; // Căn lề trái và chừa 10 ký tự trước chuỗi xin chào
            // Console.WriteLine(thongBao);
            //             string thongbao;
            //             string name = "Original NVK";
            //             int age = 21;
            //             string gioiTinh = "Nam";
            //             thongbao =
            //             $@"Ho ten: {name,10}
            // Tuoi: {age,10}
            // GioiTinh: {gioiTinh,10}
            //             ";
            //             Console.WriteLine(thongbao);

            // string thongbao = "         OriginalNVK, chao ca nha       ";
            // Để cắt bỏ khoảng trống trước và sau chuỗi ta có thể sử dụng phương thức Trim
            // thongbao = thongbao.Trim();
            // Cũng có thể chỉ muốn cắt ở đâu hoặc ở cuối bằng phương thức TrimStart và TrimEnd
            // Cũng có thể chỉ xóa đi các kí tức trước và sau chuỗi nếu trước có các dấu *
            //thongbao = thongbao.TrimStart('*');

            // Chuyển thành chuỗi in hoa
            // thongbao = thongbao.ToUpper();
            // Tương tự tolower

            // Tìm chuỗi và thay thế
            // thongbao = thongbao.Replace("chao ca nha", "Hello everyone");

            // Chèn thêm chuỗi và chuỗi cho trước
            // thongbao = thongbao.Insert(0, "2025 ");

            // Lấy chuỗi con
            // thongbao = thongbao.Substring(0, 11);

            // Xóa đi chuỗi con
            // thongbao = thongbao.Remove(11);

            // Chuyển thành chuỗi con
            // string[] arr = thongbao.Split(" ");
            // foreach(var item in arr)
            // {
            //     Console.WriteLine(item);
            // }

            // Cũng có thể chuyển chuỗi con thành chuỗi dài
            // string[] arr = { "Original", "NVK" };
            // thongbao = string.Join(" ", arr);

            // Console.WriteLine(thongbao);

            // String builder
            StringBuilder thongbao = new StringBuilder(); // Khi sử dụng nối chuyển, thay thế thì nên sử dụng StringBuilder
            // vì nó không tạo ra một chuỗi mới mà chỉ thay đổi chuỗi cũ
            thongbao.Append("Xin chao ");
            thongbao.Append("ca nha ");
            // Chuyển thành string
            string thongbaoString = thongbao.ToString();
            Console.WriteLine(thongbaoString);
        }
    }
}