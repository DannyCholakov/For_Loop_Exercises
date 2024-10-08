﻿namespace HalfSumEl;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number>max)
            {
                max = number;
            }
        }

        int sumWithoutMax = sum - max;
        if (sumWithoutMax == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = "+max);
        }
        else
        {
            int diff = Math.Abs(max - sumWithoutMax);
            Console.WriteLine("No");
            Console.WriteLine("Diff = "+diff);
        }
    }
}