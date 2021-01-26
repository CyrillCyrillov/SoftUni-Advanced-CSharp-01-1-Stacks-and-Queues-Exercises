using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int comandNumber = int.Parse(Console.ReadLine());

            Stack<int> stackNumbers = new Stack<int>();
            for (int i = 1; i <= comandNumber; i++)
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeComand = rawComand[0];

                switch (typeComand)
                {
                    case "1":
                        stackNumbers.Push(int.Parse(rawComand[1]));
                        break;

                    case "2":
                        if(stackNumbers.Count > 0)
                        {
                            stackNumbers.Pop();
                        }
                        break;

                    case "3":
                        if (stackNumbers.Any())
                        {
                            Console.WriteLine(stackNumbers.Max());
                        }
                        break;

                    case "4":

                        if (stackNumbers.Any())
                        {
                            Console.WriteLine(stackNumbers.Min());
                        }
                        break;
                    
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stackNumbers));
        }
    }
}
