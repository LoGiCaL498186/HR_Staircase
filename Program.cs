using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void staircase(int n)
    {
        // Complete this function
        string tempLine = string.Empty;
        for (int i = 1;  i <= n; i++)
        {
            tempLine = new string(' ', n - i) + new string('#', i);
            Console.WriteLine(tempLine);

        }

        Console.ReadKey();

    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}