using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Bai33
{
    // Dependency Injection
    // Dependency: phu thuoc: 
    // class A la dependency cua class B
    // Inverse of Control 
    // Khong duoc khai bao lop phu thuoc vao trong lop su dung 
    // vi khi thay doi thi lop su dung se bi anh huong
    // nen khai bao lop phu thuoc vao ben ngoai
    // Co 4 cach
    // 1. Constructor Injection
    // 2. Setter Injection
    // 3. Interface Injection
    // 4. Su dung thu vien Dependency Injection
    // Cach 4:
    // DI Container: ServiceCollection, ServiceProvider
    // Su dung ServiceProvider -> Get Service 

    // IOptions Injection: Thong so cho dich vu 
    interface IClassB
    {
        public void ActionB();
    }
    interface IClassC
    {
        public void ActionC();
    }

    class ClassC : IClassC
    {
        public ClassC() => Console.WriteLine("ClassC is created");
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        IClassC c_dependency;
        public ClassB(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }


    class ClassA
    {
        IClassB b_dependency;
        public ClassA(IClassB classb)
        {
            b_dependency = classb;
            Console.WriteLine("ClassA is created");
        }
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }

    class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("ClassC1 is created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }

    class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB1 is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
            c_dependency.ActionC();
        }
    }

    class ClassB2 : IClassB
    {
        IClassC c_dependency;
        string message;
        public ClassB2(IClassC classc, string mgs)
        {
            c_dependency = classc;
            message = mgs;
            Console.WriteLine("ClassB2 is created");
        }
        public void ActionB()
        {
            Console.WriteLine(message);
            c_dependency.ActionC();
        }
    }

    public class MyServiceOptions
    {
        public string data1 { get; set; }

        public int data2 { get; set; }
    }

    public class MyService
    {
        public string Data1 { get; set; }

        public int Data2 { get; set; }

        public MyService(IOptions<MyServiceOptions> options) // Day khong phai la dependency injection nen ta nen khai bao la IOptions<MyServiceOptions> options
        {
            var _options = options.Value;
            Data1 = _options.data1;
            Data2 = _options.data2;
        }

        public void PrintData() => Console.WriteLine($"Data1: {Data1}, Data2: {Data2}");
    }
    class Program
    {
        public static IClassB CreateB2(IServiceProvider provider) // Phuong thuc chuyen khoi tao doi tuong cho class trong DI goi la Factory
        {
            var b2 = new ClassB2(provider.GetService<IClassC>(), "Hello");
            return b2;
        }
        static void Main(string[] args)
        {
            // classB b = new classB();
            // b.ActionB();

            // var service = new ServiceCollection();

            // Dang ki dich vu


            // var a = provider.GetService<tenService>(); // lay ra dich vu de su dung
            // Lop IClassC co 2 lop con la ClassC va ClassC1
            // Dang ki su dung SingleTon
            // service.AddScoped<IClassC, ClassC>();

            // var classC = provider.GetService<IClassC>();
            // for (int i = 0; i < 5; i++)
            // {
            //     var classA = provider.GetService<IClassC>();
            //     Console.WriteLine(classA.GetHashCode());
            // }

            // using (var scope = provider.CreateScope())
            // {
            //     var provider1 = scope.ServiceProvider;
            //     for (int i = 0; i < 5; i++)
            //     {
            //         var classA = provider1.GetService<IClassC>();
            //         Console.WriteLine(classA.GetHashCode());
            //     }
            // }
            // Singleton: chi tao 1 doi tuong duy nhat trong suot vong doi cua ung dung
            // Transient: Moi lan goi se tao mot doi tuong moi
            // Scoped: chi tao 1 doi tuong trong 1 scope

            // service.AddSingleton<ClassA, ClassA>();
            // service.AddSingleton<IClassB, ClassB2>(
            //     provider =>
            //     {
            //         var b2 = new ClassB2(provider.GetService<IClassC>(), "Hello");
            //         return b2;
            //     }
            // ); // vi trong phuong thuc khoi tao co truyen chuoi string nen o day ta phai su dung delegate de truyen tham so
            // service.AddSingleton<IClassB>(CreateB2);
            // service.AddSingleton<IClassC, ClassC1>();
            // var provider = service.BuildServiceProvider();
            // ClassA a = provider.GetService<ClassA>();
            // // b.ActionB();
            // a.ActionA();

            IConfigurationRoot configurationRoot;

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("Configurate.json");

            configurationRoot = builder.Build();

            var sectionMyServiceOptions = configurationRoot.GetSection("MyServiceOption");

            var services = new ServiceCollection();

            services.AddSingleton<MyService>();
            // Vi myServiceOptions khong phai la DI nen ta khai bao Configure
            services.Configure<MyServiceOptions>(
                sectionMyServiceOptions
            );
            var provider = services.BuildServiceProvider();
            var myService = provider.GetService<MyService>();
            myService.PrintData();
        }
    }
}