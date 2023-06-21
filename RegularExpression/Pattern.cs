using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Pattern
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Email = "^[A-Za-z0-9]+([-_.+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-z]{2})?$";
        public static string MobileNumber = "^[1-9]{2}[: :][0-9]{10}$";

        //UC1-FIRST NAME
        public void validateFirstName(string fName)
        {
            if (Regex.IsMatch(fName, FirstName))
            {
                Console.WriteLine("First Name : " + fName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital and Minimum 3 character");
            }
        }

        //UC2-LAST NAME
        public void validateLastName(string lName)
        {
            if (Regex.IsMatch(lName, LastName))
            {
                Console.WriteLine("Last Name : " + lName);
            }
            else
            {
                Console.WriteLine("First alphabet should be capital and Minimum 3 character");
            }
        }

        //UC3-EMAIL
        public void validateEmail(string email)
        {
            if (Regex.IsMatch(email, Email))
            {
                Console.WriteLine("Email Address : " + email);
            }
            else
            {
                Console.WriteLine("Please enter a valid email address");
            }
        }

        //UC4-MOBILE NUMBER
        public void validateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, MobileNumber))
            {
                Console.WriteLine("Mobile Number : " + mobileNumber);
            }
            else
            {
                Console.WriteLine("Please enter a valid 10 digit mobile number with 2 digit country code ex 'xx 9xxxxxxx45'");
            }
        }
    }
}
