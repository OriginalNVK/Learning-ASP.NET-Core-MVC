public class DebitCard
{
    private string _pin;

    public string pin
    {
        set {
            bool check = true;
            if(value.Length == 4 || value.Length == 6) {
                for(int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        check = false; break;
                    }    
                }
                if (check)
                {
                    _pin = value;
                }
                else _pin = "1111";
            }
        }
        get { return _pin; }
    }
}