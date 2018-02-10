using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < number.Count; i++)
            {
                List<char> num = number[i].ToString().ToList();
                num.Reverse();
                sum += int.Parse(string.Join("", num));
            }
            Console.WriteLine(sum);
        }
    }
}
