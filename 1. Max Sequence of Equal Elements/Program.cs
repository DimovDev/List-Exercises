using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int count = 1;
            int maxcount = 0;
            int maxnumber = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;


                }
                else
                {
                    count = 1;
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    maxnumber = numbers[i];
                }
            }

                for (int i = 0; i < maxcount; i++)
                {
                    Console.Write(maxnumber + " ");
                }
            }
        }
    }

