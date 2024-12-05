using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new("./data.txt");
        string? line;

        List<int> left = [];
        List<int> right = [];

        while ((line = reader.ReadLine()) != null)
        {
            string[] numbers = line.Split("   ");

            left.Add(int.Parse(numbers[0]));
            right.Add(int.Parse(numbers[1]));
        }

        left.Sort();
        right.Sort();

        int sum = 0;
        for (int i = 0; i < left.Count; i++)
        {
            sum += Math.Abs(left[i] - right[i]);
        }

        Console.WriteLine(sum);
    }
}
