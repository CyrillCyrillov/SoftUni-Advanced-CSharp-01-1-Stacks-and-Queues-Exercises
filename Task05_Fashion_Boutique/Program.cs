using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            Stack<int> boxClothes = new Stack<int>();
            foreach (int element in clothes)
            {
                boxClothes.Push(element);
            }

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackNumber = 1;
            int curentRackValue = 0;

            while (boxClothes.Any())
            {
                int nextCloth = boxClothes.Peek();
                if(curentRackValue + nextCloth <= rackCapacity)
                {
                    curentRackValue += boxClothes.Pop();
                }
                else
                {
                    rackNumber++;
                    curentRackValue = 0;
                }
            }
            
            
            Console.WriteLine(rackNumber);
        }
    }
}
