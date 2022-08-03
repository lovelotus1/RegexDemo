using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Pattern
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";//Minimum 3 Char And 1ST Char Must Be UpperCase

        //Method for Validate First Name.
        public bool ValidateFirstName(string Firstname)
        {
            return Regex.IsMatch(Firstname, FIRST_NAME_REGEX);
        }
    }
}
