﻿using System;

namespace _1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            byte num1 = byte.Parse(s[0]);
            byte num2 = byte.Parse(s[1]);
            Console.WriteLine(P1000.Add(num1, num2));
        }
    }
}
