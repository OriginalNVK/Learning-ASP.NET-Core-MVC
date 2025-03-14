using System;

namespace MyLib
{
    public static class Xyz
    {
        public static double BinhPhuong(this double x)
        {
            return x * x;
        }

        public static double CanBac2(this double x) => Math.Sqrt(x);

        public static double Sin(this double x) => Math.Sin(x);
        public static double Cos (this double x) => Math.Cos(x);
        

    }
}