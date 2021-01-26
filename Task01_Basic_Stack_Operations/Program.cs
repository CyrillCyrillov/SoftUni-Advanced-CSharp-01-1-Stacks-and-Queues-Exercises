using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int putNumber = rawData[0];
            int exitNumber = rawData[1];
            int lookForNumber = rawData[2];

            int[] rawNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stackNumbers = new Stack<int>();
            foreach (int elemet in rawNumbers)
            {
                stackNumbers.Push(elemet);
            }

            for (int i = 1; i <= exitNumber; i++)
            {
                stackNumbers.Pop();
            }

            //bool isLookNumber = false;
            if(stackNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            
            else if(stackNumbers.Contains(lookForNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stackNumbers.Min());
            }
        }
    }
}
