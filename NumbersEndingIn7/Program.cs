﻿namespace NumbersEndingIn7;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 997; i++)
        {
            if (i%10 ==7)
            {
                Console.WriteLine(i);
            }
        }
    }
}