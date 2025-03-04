using System.Data;

public struct Catagory
{
    private int _id;
    private string _name;

    // Parameterized constructor
    public Catagory(int ID, string name)
    {
        _id = ID;
        _name = name;
    }
    // public properties
    public int ID
    {
        get { return _id; }
        set {
            if(value >= 1 && value <=100)
            _id = value; 
        }
    }
     public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int GetCatagoryNameLength()
    {
        return _name.Length;
    }
}