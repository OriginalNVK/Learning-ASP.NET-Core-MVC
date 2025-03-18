using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Bai32
{
    // Type: La lop chua thong tin ve cac kieu du lieu vd: int, string, class, struct
    // Attribute: cung cap thong tin bo sung cho lop hoac thong tin bo sung cho thanh vien cua lop
    // Reflection: thong tin kieu du lieu tai thoi diem thuc thi

    // Tao mot attribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)] // Mo ta duoc su dung o dau: class, struct, thuocTinh, PhuongThuc
    class MotaAttribute : Attribute
    {
        public string MotaChitiet { get; set; }

        public MotaAttribute(string mota)
        {
            MotaChitiet = mota;
        }
    }
    class Program
    {
        // [Mota("Lop chua thong tin ve User tren he thong")]
        class User
        {
            // [AttributeName(thamsokhoitao)]
            
            [Required(ErrorMessage = "Ten khong duoc de trong")]
            public string Name { get; set; }

            // [Mota("Tuoi cua nguoi dung")]
            [Range(18, 80, ErrorMessage = "Tuoi phai tu 18 den 80")]
            public int Age { get; set; }

            // [Mota("so dien thoai cua nguoi dung")]
            [Phone(ErrorMessage = "So dien thoai khong hop le")]
            public string PhoneNumber { get; set; }

            // [Mota("email cua nguoi dung")]
            [EmailAddress(ErrorMessage = "Email khong hop le")]
            public string Email { get; set; }

            // [Obsolete("Phuong thuc nay khong nen su dung nua")]
            public void PrintInfo() => Console.WriteLine(Name);
        }
        static void Main(string[] args)
        {
            // int[] a = { 1, 2, 3 };

            // var t = a.GetType();

            // Console.WriteLine(t.FullName);

            // // t.GetProperties().ToList().ForEach(
            // //     (o) => Console.WriteLine(o.Name)
            // // );

            // // t.GetFields().ToList().ForEach(
            // //     (o) => Console.WriteLine(o.Name)
            // // );

            // t.GetMethods().ToList().ForEach(
            //     (o) => Console.WriteLine(o.Name)
            // );

            User user = new User()
            {
                Name = "Nguyen Van A",
                Age = 20,
                PhoneNumber = "25454354354",
                Email = ""
            };

            var properties = user.GetType().GetProperties();
            // foreach (PropertyInfo property in properties)
            // {
            //     string name = property.Name;
            //     var value = property.GetValue(user);

            //     Console.WriteLine($"{name}: {value}");
            // }
            // foreach(PropertyInfo property in properties)
            // {
            //     foreach (var attribute in property.GetCustomAttributes(false))
            //     {
            //         MotaAttribute mota = attribute as MotaAttribute;
            //         if (mota != null)
            //         {
            //             var value = property.GetValue(user);
            //             var name = property.Name;
            //             Console.WriteLine($"{name}({mota.MotaChitiet}): {value}");
            //         }

            //     }
            // }

            ValidationContext context = new ValidationContext(user);
            var results = new List<ValidationResult>();

            bool kq = Validator.TryValidateObject(user, context, results, true);
            if (kq == false)
            {
                Console.WriteLine("nhung loi hien co:");
                results.ToList().ForEach(
                    (o) => Console.WriteLine(o.ErrorMessage)
                );
            }

        }
    }
}