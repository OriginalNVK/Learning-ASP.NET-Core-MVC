using System;

class Program
{
    static void Main()
    {
        CD obj1 = new CD();
        obj1.Artist = "Nguyen Van Khanh";
        obj1.Title = "Original NVK";
        obj1.NumberOfTracks = 10;
        obj1.LoanPeriod = 3;
        obj1.Borrower = "Van Ho Phuong Ha";
        obj1.print();
        Console.WriteLine();

        DVD obj2 = new DVD();
        obj2.Director = "Nguyen Phan Duc Khai";
        obj2.LengthInMinute = 100;
        obj2.Title = "Love";
        obj2.Borrower = "Pham Thien An";
        obj2.LoanPeriod = 3;
        obj2.print();
        Console.WriteLine();

        Book obj3 = new Book();
        obj3.Author = "Nguyen Van Chien";
        //obj3.ISBN = true;
        obj3.Title = "Love An Le";
        obj3.LoanPeriod = 3;
        obj3.Borrower = "An Le";
        obj3.print();

    }
}