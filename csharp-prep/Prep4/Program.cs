using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int addlist;

        Console.Write("Add non-zero numbers to the list, then add '0' to the list when you are finished: ");
        addlist = int.Parse(Console.ReadLine());
        int total = 0;
        int high = 0;

        while (addlist != 0)
        {
            nums.Add(addlist);
            Console.Write("Add a number: ");
            addlist = int.Parse(Console.ReadLine());
        }

        foreach (int num in nums)
        {
            total += num;
            if (num > high)
            {
                high = num;
            }
        }

        int avg = (nums.Count > 0) ? (total / nums.Count) : 0; 

        Console.WriteLine($"Count: {nums.Count}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {avg}"); 
        Console.WriteLine($"Highest: {high}");
    }
}
