using System;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int divider= 8;
            int endValue=int.Parse(Console.ReadLine());
            for (int i = 1; i <=endValue; i++)
            {
                if (IsSumOfDigitsDivisible(i,divider)&&IsItHoldsAnOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsSumOfDigitsDivisible(int currentNumber,int divider)
        {
            string number= currentNumber.ToString();
            
            int sum0fdigit = 0;
            for (int i = 0; i < number.Length; i++)
            {                
                sum0fdigit+=int.Parse(number[i].ToString());
            }
            if (sum0fdigit%divider==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsItHoldsAnOddDigit(int currentNumber)
        {
            bool isThereOdd=false;
            string number = currentNumber.ToString();
            char[] oddDigits = new char[] { '1', '3', '5', '7', '9' };
            foreach (char item in number)
            {
                if (oddDigits.Contains(item))
                {
                    isThereOdd= true; 
                }                                
            }
            return isThereOdd;
        }
    }
}
