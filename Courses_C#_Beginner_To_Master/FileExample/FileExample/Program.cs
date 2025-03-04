using System;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace FileExample
{
   public  class Product
    {
        public int Id { get; set; } 

        public double Price { get; set; }

        public string Name { get; set; }

        public void Save(Stream stream)
        {
            // int --> 4  bytes
            var bytes_id = BitConverter.GetBytes(Id);
            stream.Write(bytes_id, 0, 4);
            
            // double --> 8 bytes
            var bytes_price = BitConverter.GetBytes(Price);
            stream.Write(bytes_price, 0, 8);

            // string --> length
            var bytes_name = Encoding.UTF8.GetBytes(Name);
            var bytes_length = BitConverter.GetBytes(bytes_name.Length);
            stream.Write(bytes_length, 0, 4);
            stream.Write(bytes_name, 0, bytes_name.Length);
        }

        public void ReStore(Stream stream)
        { 
            // Phục hồi ID
            var bytes_id = new byte[4];
            stream.Read(bytes_id, 0, 4);
            Id = BitConverter.ToInt32(bytes_id,0);

            var bytes_price = new byte[8];
            stream.Read(bytes_price, 0, 8);
            Price = BitConverter.ToDouble(bytes_price, 0);

            var bytes_length = new byte[4];
            stream.Read(bytes_length, 0, 4);
            int length = BitConverter.ToInt32(bytes_length, 0);

            var bytes_name = new byte[length];
            stream.Read(bytes_name, 0, length);
            Name = Encoding.UTF8.GetString(bytes_name);
        }
    }
    internal class Program
    {
        static void Main()
        {
            #region Drive - Lớp làm việc với ổ đĩa
            //var drives = DriveInfo.GetDrives();

            ////DriveInfo drive = new DriveInfo("C");
            //foreach(var drive in drives)
            //{
            //    Console.WriteLine($"Drive: {drive.Name}");
            //    Console.WriteLine($"Drive Type: {drive.DriveType}");
            //    Console.WriteLine($"Label: {drive.VolumeLabel}");
            //    Console.WriteLine($"Size: {drive.TotalSize}");
            //    Console.WriteLine($"FreeSize: {drive.TotalFreeSpace}");
            //    Console.WriteLine($"Format: {drive.DriveFormat}");
            //}

            #endregion

            #region Directory - Lớp làm việc với thư mục
            //string path = "ABC";

            //Directory.Delete(path);
            //if(Directory.Exists(path)) {
            //    Console.WriteLine($"{path} is exists");

            //}
            //else
            //{
            //    Console.WriteLine($"{path} is not exists");
            //}
            //var files = Directory.GetFiles(path);
            //var directories = Directory.GetDirectories(path);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //foreach(var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}
            #endregion

            #region Lớp path - Hỗ trợ làm việc với đường dẫn
            //Console.WriteLine(Path.DirectorySeparatorChar);

            //var path = Path.Combine("Dir1", "Dir2", "Tenfile.txt"); // Nối tạo đường dẫn
            //Console.WriteLine(path);
            //var path2 = "Dir1\\Dir2\\Tenfile.txt";
            //path2 = Path.ChangeExtension(path2, "md"); // Thay đổi phần mở rộng của file
            //Console.WriteLine(path2);
            //Console.WriteLine(Path.GetDirectoryName(path));
            //Console.WriteLine(Path.GetExtension(path));
            //Console.ReadKey();
            #endregion

            #region Lớp File
            //string fileName = "abc.txt";

            //string content = "Xin chao cac ban 2025";
            //string content2 = "\nXin chao chu tich";
            //File.WriteAllText(fileName, content); // Ghi nội dung vào file
            //File.AppendAllText(fileName, content2); // chèn thêm nội dung vào file

            //string content = File.ReadAllText(fileName); // Đọc nội dung của file
            //Console.WriteLine(content);

            //File.Move(fileName, "Original NVK.txt"); // Đổi tên file

            //File.Copy(fileName, "CEO.txt"); // Copy file

            //File.Delete(fileName);
            //Console.ReadKey();

            #endregion

            #region Lớp FileStream - Mở file đọc và lưu dữ liệu vào file
            string path = "data.txt";
            using var stream = new FileStream(path: path, FileMode.Open); // Mở file với tên file như trên với phương thức là mở hoặc tạo 
            // Từ khóa using để tự động giải phóng stream khi sử dụng xong

            Product product = new Product()
            {
                Id = 10,
                Price = 12345,
                Name = "San pham ABC"
            };
            product.Save(stream);

            Product product2 = new Product();

            product2.ReStore(stream);

            Console.WriteLine($"{product2.Id} - {product2.Price} - {product2.Name}");
            // Lưu dữ liệu
            //byte[] buffer = { 1, 2, 3 };
            //int offset = 0;
            //int count = buffer.Length;
            //stream.Write(buffer, 0, 3);

            ////Đọc dữ liệu
            //int soByteDocDuoc = stream.Read(buffer, 0, 3);

            //// int, double --> bytes
            //int abc = 1;
            //var bytes_abc = BitConverter.GetBytes(abc);

            //// bytes --> int, double
            //int abc1 = BitConverter.ToInt32(bytes_abc, 0);

            //// string --> bytes
            //string s = "abc";
            //var bytes_s = Encoding.UTF8.GetBytes(s);

            //// Bytes -- >string
            //string s2 = Encoding.UTF8.GetString(bytes_s);

            
            #endregion
        }
    }
}
