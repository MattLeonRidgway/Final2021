using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Final2021
{
    class ValidateClass
    {/* Validation class
      * Used to test strings, int, email alphanumeric
      * Check list size
      * 
      */


        /* isValidString
         * Checks for empty string and if text entered is a valid string
         * 
         */
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
        /* isValidAlphnamuric
         * Validate a textbox and uses regex to match alphanumeric
         * 
         */
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
        /* isValidEmail
         * Validates EMAIL addresss
         */
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
        
        /* checkListSize
         * Checks IF size is less than one
         */
        public bool checkList(List<string> passedList)
        {
            if (passedList.Count <= 1)
            {
                return false;
            }
            else { 
              return true;
            }
          
        }
    }
   
}
