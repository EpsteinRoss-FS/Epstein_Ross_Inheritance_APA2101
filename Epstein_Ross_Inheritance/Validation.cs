/** 
 * Ross Epstein
 * CE02 - Inheritance
 * 01-10-2021
 * **/
using System;
using System.Collections.Generic;
using System.Text;

namespace Epstein_Ross_CE02
{
    class Validation
    {

        //validate that string provided is > 1
        public static bool ValidateString(string validateString) 
        {
            bool stringValid = validateString.Length >= 1 ? true : false;
            return stringValid;
        }

        //verify that passed string is an int
        public static bool CheckInt(string intCheck)
        {
            bool isItInt = int.TryParse(intCheck, out _);
            return (isItInt);
        }

        //verify that the provided int is in range
        public static bool CheckRange(int num, int maxNum)
        {
            bool isInRange = (num >= 0 && num <= maxNum);
            return (isInRange);
        }
    }
}
