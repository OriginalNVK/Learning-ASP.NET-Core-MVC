using System;

public class Manager : IEmployee
{
    // field
    private string _departmentName;
    private int _empID;
    private string _empName;
    private string _location;

    // Constructor Manager
    public Manager(int empID, string empName, string location, string departmentName)
    {
        this._empID = empID;
        this._empName = empName;
        this._location = location;
        this._departmentName = departmentName;
    }

    //properties
    public string departmentName
    {
        set { _departmentName = value; }
        get { return _departmentName; }
    }

    public int EmpID
    {
        set
        {
            if (value >= 1000 && value <= 2000)
            {
                _empID = value;
            }
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
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }

    // method

    public long GetTotolSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return departmentName + " at " + _location;
    }

    // method override 
    public string GetHealthInsuranceAmount()
    {
        //Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Addition Health insurance premium is : 10000";
    }
}