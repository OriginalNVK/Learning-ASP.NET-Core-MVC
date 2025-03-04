﻿namespace Warehouse
{
    public partial class Product
    {
        // private field

        private double _cost;

        // public property
        public double Cost
        {
            get; set;
        } = default;

        partial void GetTax()
        {
            double tax = Cost * 10 / 100;
            System.Console.WriteLine(tax);
        }
    }
}
