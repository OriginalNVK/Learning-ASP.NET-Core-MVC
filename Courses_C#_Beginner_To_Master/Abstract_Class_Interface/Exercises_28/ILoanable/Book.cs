using System;

public class Book: ILoanable, IPrintable
{
    int _loanPeriod;
    string _borrower;
    string _author;
    string _title;
    //bool _ISBN;
    public int LoanPeriod
    {
        get
        {
            return (int)this._loanPeriod;
        }
        set {
        this._loanPeriod = 21;
        }
    }

    public string Borrower
    {
        get
        {
            return this._borrower;
        }
        set
        {
            this._borrower = value;
        }
    }

    public string Author
    {
        get
        {
            return this._author;
        }
        set
        {
            this._author = value;
        }
    }

    public string Title
    {
        get
        {
            return this._title;
        }
        set { 
            this._title = value;    
        }
    }

    /*public bool ISBN
    {
        get
        {
            return this._ISBN;
        }
        set { 
            _ISBN = value; 
        }
    }*/

    public void print()
    {
        Console.WriteLine("The author of the book is: " + this.Author);
        Console.WriteLine("The title of the book is: " + this.Title);
       /* if(this.ISBN)
        {
            Console.WriteLine("The book is BN");
        }
        else
        {
            Console.WriteLine("The book is not BN");
        }*/
        Console.WriteLine("The loanable of the book is " + this.LoanPeriod);
        Console.WriteLine("The borrower's Name of the book is " + this.Borrower);
    }
}