using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04_Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> orderQueue = new Queue<int>();
            foreach (int elelement in orders)
            {
                orderQueue.Enqueue(elelement);
            }

            Console.WriteLine(orderQueue.Max());

            while (true)
            {
                if(foodQuantity < orderQueue.Peek())
                {
                    break; 
                }

                foodQuantity -= orderQueue.Dequeue();

                if (!orderQueue.Any())
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }

            if (orderQueue.Any())
            {
                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(", ", orderQueue));
            }
            
        }
    }
}
