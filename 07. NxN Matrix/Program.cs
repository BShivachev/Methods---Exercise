using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMatrix(int.Parse(Console.ReadLine()));
        }
        static void GetMatrix(int filter)
        {
            for (int i = 0; i < filter; i++)
            {
                for (int j = 0; j < filter; j++)
                {
                    Console.Write($"{filter} ");
                }
                Console.WriteLine();
            }
        }
    }
}
