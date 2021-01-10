using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
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

        public static bool CheckRange(int num, int maxNum)
        {
            bool isInRange = (num > 0 && num <= maxNum);
            return (isInRange);
        }
    }
}
