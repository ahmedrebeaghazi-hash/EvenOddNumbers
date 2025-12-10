using System;
using System.Collections.Generic;
namespace EvenOddNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintNumbers("Numbers :", Numbers.Where(x => Even(x)));

            PrintNumbers("Numbers :", Numbers.Where(x => Odd(x)));


        }
        static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine(title);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
        static bool Even(int Number)
        {
            if(Number > 0 && Number %2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Odd(int Number)
        {
            if (Number > 0 && Number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}