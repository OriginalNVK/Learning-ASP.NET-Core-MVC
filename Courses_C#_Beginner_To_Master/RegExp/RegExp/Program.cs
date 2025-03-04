using System;
using System.Text.RegularExpressions;

namespace RegExp
{
    internal class Program
    {
        bool MaskCreditCard(string input)
        {
            Regex regex = new Regex("/d{4}-/d{4}-/d{4}-/d{4}");
            bool result = regex.IsMatch(input);
            return result;
        }

        bool MaskSocialScurity(string input)
        {
            Regex regex = new Regex("/d{3}-45-/d{4}");
            bool result = regex.IsMatch(input);
            return result;
        }


        static void Main()
        {
            
        }
    }
}
