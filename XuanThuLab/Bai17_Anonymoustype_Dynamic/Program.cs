using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai17_Anonymous
{
    class Program
    {
        // Anonymous type - Kieu du lieu vo danh
        // Object - thuoc tinh - chi doc
        // new {thuoctinh = giatri, thuoctinh2 = giatri2}\
        // Chi duoc gan gia tri 1 lan

        // dynamic - kieu du lieu dong


        class SinhVien
        {
            public string HOten { get; set; }

            public int NamSinh { get; set; }

            public string NoiSinh { get; set; }
        }
        static void Main(string[] args)
        {
            // var sanpham = new
            // {
            //     ten = "Iphone 11 pro max",
            //     gia = 65000,
            //     NamSX = 2020
            // };
            // Console.WriteLine($"Ten san pham: {sanpham.ten}");
            // Console.WriteLine($"Gia san pham: {sanpham.gia}");
            // Console.WriteLine($"Nam san xuat: {sanpham.NamSX}");

            // List<SinhVien> cacSinhVien = new List<SinhVien>()
            // {
            //     new SinhVien {HOten = "Nguyen Van A", NamSinh = 1999, NoiSinh = "Ha Noi"},
            //     new SinhVien {HOten = "Nguyen Van B", NamSinh = 1998, NoiSinh = "Ha Noi"},
            //     new SinhVien {HOten = "Nguyen Van C", NamSinh = 1997, NoiSinh = "Ha Noi"},
            // };

            // var TapSinhVien = from sv in cacSinhVien
            //                   where sv.NamSinh <= 2001
            //                   select new { Ten = sv.HOten, NamSinh = sv.NamSinh };

            // foreach (var sv in TapSinhVien)
            // {
            //     Console.WriteLine($"Ten: {sv.Ten}, Nam sinh: {sv.NamSinh}");
            // }

            dynamic tenbien1; // kieu du lieu duoc xac dinh tai thoi diem bien dich
            var tenbien2 = 123; // kieu du lieu duoc xac dinh ngay tai thoi diem gan gia tri

            // tuc la khi build chuong trinh thi kieu du lieu dynamic cho phep chung ta viet 
            // cac thuoc tinh hay phuong thuc du khong co thi cung khong gay loi 
            // tuy nhien ngay tai thoi diem bien dich tuc ngay sau khi go dotnet run
            // loi se xuat hien 
            

        }
    }
}