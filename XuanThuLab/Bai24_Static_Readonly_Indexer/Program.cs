using System;

namespace Bai24
{
    class CountNumber
    {
        public static int number = 0;
        public static void Info()
        {
            Console.WriteLine($"So Lan Truy Cap: {number}");
        }

        public void Count()
        {
            CountNumber.number += 1;
        }
    }

    class Student
    {
        public readonly string name;
        public Student(string _name) {
            name = _name;
        }

    }

    class Vector
    {
        double x;
        double y;

        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public void Info()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }

        // Toan tu + -> v3 = v1 + v2
        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector v3 = new Vector(v1.x + v2.x, v1.y + v2.y);
            return v3;
        }
        // tao indexer vd: v[0] = 1, v[1] = 2 hoac v["x"] = 1, v["y"] = 2
        // cu phap tao indexer
        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            get
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();

            // c1.Count();
            // c2.Count();
            // CountNumber.Info();

            Vector v1 = new Vector(1, 2);
            Vector v2 = new Vector(2, 3);

            Vector v3 = v1 + v2;
            v3.Info();
        }
    }
}