using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02_Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int putNumber = rawData[0];
            int exitNumber = rawData[1];
            int lookNumber = rawData[2];

            int[] rawNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> queueNumbers = new Queue<int>();
            for (int i = 0; i <= putNumber - 1; i++)
            {
                queueNumbers.Enqueue(rawNumbers[i]);
            }

            for (int i = 1; i <= exitNumber; i++)
            {
                queueNumbers.Dequeue();
            }

            if(queueNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(queueNumbers.Contains(lookNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queueNumbers.Min());
            }
        }
    }
}
