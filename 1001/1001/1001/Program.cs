using System;

namespace _1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            sbyte num1 = sbyte.Parse(s[0]);
            sbyte num2 = sbyte.Parse(s[1]);
            Console.WriteLine(P1001.Subtraction(num1, num2));
        }
    }
}
