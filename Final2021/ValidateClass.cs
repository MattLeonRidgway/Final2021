using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Final2021
{
    class ValidateClass
    {/* Validation class
      * Used to test strings, int, email alphanumeric
      * Check list size
      * Check for null or empty
      * 
      */
        /* nullOrEmpty
         * input string is checked for null or an empty string
         */
        public static bool nullOrEmpty(string input) {
           
            if (string.IsNullOrEmpty(input)) {// Validate for empty text box
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /* isValidString
         * Validate using regex string
         * 
         */
        public static bool isValidString(string input)
        {
            bool validateString = true;
            if (nullOrEmpty(input)) { 
                validateString = false;
            }                
            else
            {
                validateString = Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
            }
            return validateString;
        }
        /* isValidAlphnamuric
         * Use regex to match alphanumeric
         * 
         */
        public static bool isValidAlphanumeric(string input)
        {
            bool validateString = true;
            if (nullOrEmpty(input)) { 
               validateString = false;
            }             
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
            if (nullOrEmpty(input)) { 
             validateEmail = false;
            }               
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
