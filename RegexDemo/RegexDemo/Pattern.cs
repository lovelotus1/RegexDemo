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
        //Method to check and take the first name using regex(UC1)
        public void CheckFirstName()
        {

            string firstName = Console.ReadLine();
            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string FirstNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, FirstNamePattern))
            {
                Console.WriteLine("\tThe entered first name is valid");
            }
            else
            {
                Console.WriteLine("\tFirst name should starts with Cap and should have minimum 3 characters");
            }
        }
        public void CheckLastName()
        {
            string LastName = Console.ReadLine();
            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
            string LastNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(LastName, LastNamePattern))
            {
                Console.WriteLine("\tThe given last name is valid");
            }
            else
            {
                Console.WriteLine("\tLast name should starts with UpperCase and should have minimum 3 characters");
            }

        }
    }
}
