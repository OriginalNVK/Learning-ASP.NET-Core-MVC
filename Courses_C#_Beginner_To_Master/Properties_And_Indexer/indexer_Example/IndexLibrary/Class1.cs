using System;

public class car
{
    // Private
    private string[] _brands = new string[] { "BMW", "Skoda", "Honda"};
    private string[] _names = new string[] { "first", "second", "third" };

    //Public indexer
    public string this[int index]
    {
        get
        {
            return _brands[index];
        }
        set
        { 
            this._brands[index] = value;
        }
    }

    public string this[string name]
    {
        set
        {
            this._brands[Array.IndexOf(_names, name)] = value;
        }

        get
        {
            return _brands[Array.IndexOf(_names, name)];
        }
    }


}