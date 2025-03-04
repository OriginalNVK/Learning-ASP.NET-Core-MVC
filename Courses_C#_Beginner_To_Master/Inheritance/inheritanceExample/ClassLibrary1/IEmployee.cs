public interface IEmployee
{
    // properties

    int EmpID
    {
        set;
        get;
    }

    string EmpName
    {
        set;
        get;
    }

    string Location
    {
        set;
        get;
    }

    // abstract method
    string GetHealthInsuranceAmount();
}