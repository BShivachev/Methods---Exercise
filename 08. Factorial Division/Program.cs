using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double result = GetFactorial(firstNumber) / GetFactorial(secondNumber);
            Console.WriteLine($"{(double)result:f2}");

        }
        static double GetFactorial(int number)
        {
            double factorial = 1;
            if (number == 0)
            {
                factorial = 1;
            }
            else
            {

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            return factorial;
        }
    }
}
