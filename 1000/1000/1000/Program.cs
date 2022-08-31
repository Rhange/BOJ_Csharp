using System;

namespace _1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Console.WriteLine(P1000.add(int.Parse(s[0]), int.Parse(s[1])));
        }
    }
}
