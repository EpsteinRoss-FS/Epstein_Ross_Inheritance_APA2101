using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_Inheritance
{
    class Validation
    {

        public static bool ValidateString(string validateString) 
        {
            bool stringValid = validateString.Length >= 1 ? true : false;
            return stringValid;
        }

        public static bool CheckInt(string intCheck)
        {
            bool isItInt = int.TryParse(intCheck, out _);
            return (isItInt);
        }
    }
}
