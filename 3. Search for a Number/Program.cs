using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> command = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            if (number.Take(command[0]).
                Skip(command[1]).Contains(command[2])) { Console.WriteLine("YES!"); }
            else { Console.WriteLine("NO!"); }

        }
    }
}
