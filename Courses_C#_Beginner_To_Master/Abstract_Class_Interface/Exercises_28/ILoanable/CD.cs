using System;

public class CD: ILoanable, IPrintable
{
    string _artist;
    string _title;
    int _numberOfTracks;
    int _loanPeriod;
    string _borrower;

    public string Artist
    {
        get { return _artist; }
        set { _artist = value; }
    }

    public string Title
    {
        get
        {
            return _title;
        }
        set { _title = value; }
    }

    public int NumberOfTracks
    {
        get { return _numberOfTracks; }
        set { _numberOfTracks = value; }
    }

    public int LoanPeriod
    {
        get { return _loanPeriod; }
        set { _loanPeriod = 14; }
    }

    public string Borrower
    {
       get
        {
            return _borrower;
        }
        set { _borrower = value; }
    }

    public void print()
    {
        Console.WriteLine("The Artist of the CD is: " + this.Artist);
        Console.WriteLine("The title of the CD is: " + this.Title);
        Console.WriteLine("The number of tracks of CD is: " + this.NumberOfTracks);
        Console.WriteLine("The loan period of the CD is: " + this.LoanPeriod);
        Console.WriteLine("The borrower's name of the CD is: " + this.Borrower);
    }
}