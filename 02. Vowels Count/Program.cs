using System;
using System.Linq;   

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string=Console.ReadLine();
            Console.WriteLine(GetNumberOfVowels(@string));
        }
        static int GetNumberOfVowels(string word)
        {
            char[] vowels = new char[] { 'a','o','e','i','u' };
            int numberOfVowels=0;
            foreach (char item in word.ToLower())
            {
                if (vowels.Contains(item))
                {
                    numberOfVowels++;
                }
            }
            return numberOfVowels;
        }
    }
}
