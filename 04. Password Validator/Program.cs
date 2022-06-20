using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            const int minChars = 6;
            const int maxChars = 10;
            const int minDigitscount = 2;

            bool isPasswordValid= IsPasswordValid(password, minChars, maxChars, minDigitscount);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }            
           
        }
        static bool IsPasswordValid(string password, int minLenght, int maxLenght, int minDigits)
        {
            bool isPasswordValid = true;
            if (!IsPasswordInCorrectBounds(password, minLenght, maxLenght))
            {
                Console.WriteLine($"Password must be between {minLenght} and {maxLenght} characters");
                isPasswordValid= false;
            }
            if (!IsPasswordConsistOfOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!IsPasswordHaveEnoughDigits(password, minDigits))
            {
                Console.WriteLine($"Password must have at least {minDigits} digits");
                isPasswordValid = false;
            }
            return isPasswordValid;
        }
        static bool IsPasswordInCorrectBounds(string password, int minChars, int maxChars)
        {
            int countOfChars = 0;
            for (int i = 0; i < password.Length; i++)
            {
                countOfChars++;
            }
            if (countOfChars > maxChars || countOfChars < minChars)
            {
                return false;
            }
            return true;
        }
        static bool IsPasswordConsistOfOnlyLettersAndDigits(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordHaveEnoughDigits(string password, int minDigits)
        {
            int countOfDigits = 0;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    countOfDigits++;
                }
            }
            if (countOfDigits >= minDigits)
            {
                return true;
            }
            return false;

        }
    }
}
