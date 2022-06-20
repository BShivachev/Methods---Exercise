using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar= char.Parse(Console.ReadLine());
            if (secondChar<firstChar)
            {
                GetCharsBetweenTwoChars(secondChar, firstChar);
            }
            GetCharsBetweenTwoChars(firstChar, secondChar);
        }
        static void GetCharsBetweenTwoChars(char first,char second)
        {
            
            for (char i = (char)(first + 1); i < second; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
