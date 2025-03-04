using System;

public class DVD: ILoanable, IPrintable
{
    string _director;
    string _title;
    int _lengthInMinute;
    int _loanPeriod;
    string _borrower;

    public string Director
    {
        get
        {
            return _director;
        }
        set
        {
            _director = value;
        }
    }

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }

    public int LengthInMinute
    {
        get
        {
            return _lengthInMinute;
        }
        set
        {
            _lengthInMinute = value;
        }
    }

    public int LoanPeriod
    {
        get
        {
            return _loanPeriod;
        }
        set
        {
            _loanPeriod = 7;
        }
    }

    public string Borrower
    {
        get
        {
            return _borrower;
        }
        set { _borrower = value;}
    }

    public void print()
    {
        Console.WriteLine("The director of the DVD is: " + this.Director);
        Console.WriteLine("The title of the DVD is: " + this.Title);
        Console.WriteLine("The length of minute of the DVD is: " + this.LengthInMinute);
        Console.WriteLine("The loan period of the DVD is: " + this.LoanPeriod);
        Console.WriteLine("The borrower's name of the DVD is: " + this.Borrower);
    }
}