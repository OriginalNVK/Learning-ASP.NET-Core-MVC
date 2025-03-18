using System;
using Newtonsoft.Json;
using XTLab.Utils;

namespace Bai31
{

    class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }

        public string[] Sizes { get; set; }


    }
    class Program
    {

        // Bai 31: Nuget
        // dotnet add package <package_name> --version <version>
        // dotnet remove package <package_name>
        // dotnet restore


        static void Main(string[] args)
        {
            // Product product = new Product();
            // product.Name = "Apple";
            // product.Expiry = new DateTime(2021, 12, 31);
            // product.Sizes = new string[] { "Small" };

            // string json = JsonConvert.SerializeObject(product);
            // Console.WriteLine(json);

            // dotnet add D:\Work\ProfessionalProject\Learning-ASP.NET-API\XuanThuLab\Bai31_Nuget\Bai31_Nuget.csproj reference D:\Work\ProfessionalProject\Learning-ASP.NET-API\XuanThuLab\Utils\Utils.csproj
            //     string json = @"{
            //         ""Name"": ""Apple"",
            //         ""Expiry"": ""2025-3-18T00:00:00"",
            //         ""Sizes"": [
            //             ""Small"",
            //             ""Medium""
            //             ]
            // }";

            //     Product product = JsonConvert.DeserializeObject<Product>(json);
            //     Console.WriteLine(product.Name);

            double a = 4353452435435;
            var kq = ConvertMoneyToText.NumberToText(a);
            Console.WriteLine(kq);
        }
    }
}