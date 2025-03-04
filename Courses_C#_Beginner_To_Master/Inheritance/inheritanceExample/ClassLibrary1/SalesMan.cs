public class SalesMan : IEmployee
{
    private int _empID;
    private string _empName;
    private string _location;
    private string _region;

    // constructor Sales Man
    public SalesMan(int empID, string empName, string location, string region)
    {
        this._empID  = empID;
        this._empName = empName;
        this._location = location;
        this._region = region;
    }

    // properties
    public string Region
    {
       set { _region = value; }
        get { return _region; }
    }

    public int EmpID
    {
        set
        {
            if (value >= 500 && value <= 1000)
                _empID = value;
            else _empID = 0;
        }
        get { return _empID; }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get { return _empName; }   
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get { return _location; }   
    }

    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }

    // method overriding the abstract method 
    public string GetHealthInsuranceAmount()
    {
        return "Additional Health Insurance premium amount is: 1000";
    }
}