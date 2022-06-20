using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firtstNum=int.Parse(Console.ReadLine());
            int secondNum=int.Parse(Console.ReadLine());
            int thirdNum=int.Parse(Console.ReadLine());
            PrintSmallestNumber(firtstNum, secondNum, thirdNum);
        }
        static void PrintSmallestNumber(int first,int second,int third)
        {
            int [] arrOfNums = new int[] {first,second,third};
            int smallestNum = int.MaxValue;
            foreach (int item in arrOfNums)
            {
                if (item<smallestNum)
                {
                    smallestNum = item;
                }
            }
            Console.WriteLine(smallestNum);
            
        }
    }
}
