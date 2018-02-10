using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();



            var comand = Console.ReadLine().Split().ToList();
            while (comand[0] != "Odd" && comand[0] != "Even")
            {


                switch (comand[0])
                {
                    case "Delete":
                        int item = int.Parse(comand[1]);
                        numbers.RemoveAll(x =>x== item);
                        break;
                    case "Insert":
                        numbers.Insert((int.Parse)(comand[2]), (int.Parse)(comand[1]));
                        break;
                }
                comand = Console.ReadLine().Split().ToList();


            }
            if (comand[0] == "Odd")
            {
                 numbers.RemoveAll(x => x % 2 == 0);
            }
            else if (comand[0] == "Even")
            {
                 numbers.RemoveAll(x => x % 2 == 1);
            }
            Console.WriteLine(string.Join(" ", numbers));

        }


    }
}


    

