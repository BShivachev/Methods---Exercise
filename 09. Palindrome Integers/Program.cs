using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                
                Console.WriteLine(IsNumberAPalindrome(command));
                
            }
        }
        static string IsNumberAPalindrome(string num)
        {
            
              
            if (num.SequenceEqual(num.Reverse()))
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
