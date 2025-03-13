using System;
using System.Security.Cryptography.X509Certificates;

namespace Bai12_Struct_Enum
{
    // public struct Product // Struct là kiểu dữ liệu giống class, nhưng không hỗ trợ kế thừa, không hỗ trợ constructor, destructor, không hỗ trợ overload toán tử
    // // Struct là kiểu dữ liệu tham trị, không phải tham chiếu lưu trữ trên stack, không phải heap
    // {
    //     // dữ liệu
    //     public string name { get; set; }
    //     public double price { get; set; }

    //     // Phương thức
    //     public string getInfo()
    //     {
    //         return $"Ten san pham la: {name}, gia san pham la: {price}";
    //     }
    //     // Khởi tạo
    //     public Product(string name, double price) // Đã là hàm khởi tạo thì phải có giá trị cho cả 2 trường dữ liệu
    //     {
    //         this.name = name;
    //         this.price = price;
    //     } // Tức là khi có 2 đối tượng gán bằng thì 2 đối tượng đó vẫn là 2 đối tượng riêng biệt
    //     public string info
    //     {
    //         get
    //         {
    //             return $"Ten san pham: {name}, gia san pham: {price}";
    //         }
    //     }
    // }

    enum HOCLUC
    {
        Kem, Trung_Binh, Kha, Gioi, Xuat_Sac
        // 0 - 1 - 2 - 3 - 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            // struct
            // Product sanpham1 = new Product("Iphone 12", 1000);
            // Console.WriteLine(sanpham1.getInfo());
            // Product sanpham2 = new Product("Iphone 100", 2000);
            // Console.WriteLine(sanpham2.info);
            // sanpham1 = sanpham2;
            // sanpham2.name = "Iphone X";
            // Console.WriteLine(sanpham1.info);
            // Console.WriteLine(sanpham2.info);

            // Enum
            // Enum là kiểu dữ liệu giới hạn giá trị của nó

            HOCLUC hocluc;
            hocluc = HOCLUC.Gioi;
        }
    }
}