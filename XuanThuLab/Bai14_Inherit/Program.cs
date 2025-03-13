using System;

namespace Bai14_Inherit
{
    // Tinh ke thua trong C#
    public class Animal
    {
        public int legs { get; set; }

        public double weight { get; set; }

        public Animal()
        {
            Console.WriteLine("Khoi tao Animal");
        }

        public Animal(string s)
        {
            Console.WriteLine("Khoi tao Animal (2)");
        }
        public void ShowLegs()
        {
            Console.WriteLine("So chan: " + legs);
        }
    }

    public class Cat : Animal
    {
        public string Food { get; set; }

        public Cat() : base("abc")
        {
            Console.WriteLine("Khoi tao Cat");
        }

        public void Eat()
        {
            Console.WriteLine($"Thuc an cua meo: {Food}");
        }

        public new void ShowLegs()
        {
            Console.WriteLine("So chan cua loai meo: " + legs);
        }

        public void ShowInfo()
        {
            base.ShowLegs();
            ShowLegs();
        }
    }
    // Khi co 3 lop A, B, C trong do B ke thua A, C ke thua B
    // khi do doi tuong lop A se co the gan bang new B hoac new C nhung neu C gan bang B thi se gay ra loi
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

        }
    }
}