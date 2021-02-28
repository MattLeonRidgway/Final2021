using System.Text.RegularExpressions;

namespace Final2021
{
    class ValidateClass
    {


        //check string for ONLY letters
        public static bool isValidString(string input)
        {
            bool validateString = true;
            if (string.IsNullOrEmpty(input))// Validate for empty text box
                validateString = false;
            else
            {
                validateString = Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
            }
            return validateString;
        }
        //Check for string and number
        public static bool isValidAlphanumeric(string input)
        {
            bool validateString = true;
            if (string.IsNullOrEmpty(input))// Validate for empty text box
                validateString = false;
            else
            {
                validateString = Regex.IsMatch(input, @"^[a-zA-Z0-9\s]+$");
            }
            return validateString;
        }
        //check email
        public static bool isValidEmail(string input)
        {
            bool validateEmail = true;
            if (string.IsNullOrEmpty(input))// Validate for empty text box
                validateEmail = false;
            else
            {
                validateEmail = Regex.IsMatch(input, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            }
            return validateEmail;
        }

    }
}
