using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            Console.WriteLine(GetMiddleChar(@string));
        }
        static string GetMiddleChar(string theString)
        {
            string middleChar = string.Empty;
            if (theString.Length % 2 != 0)
            {
                char midCh = theString[theString.Length / 2];
                middleChar=midCh.ToString();
            }
            else
            {
                for (int i = 1; i <= theString.Length; i++)
                {
                    if (i==theString.Length/2-1||i==theString.Length/2)
                    {
                        middleChar += theString[i];
                    }
                }
            }
                return middleChar;
        }
    }
}
