using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firsNum=int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            int thirdNum=int.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(firsNum,secondNum,thirdNum));

        }
        static int GetSum(int first,int second)
        {
            int sum = first + second;
            return sum;
        }
        static int GetResult(int first,int second,int third)
        {
            int result = GetSum(first, second) - third;
            return result;
        }

        
    }
}
