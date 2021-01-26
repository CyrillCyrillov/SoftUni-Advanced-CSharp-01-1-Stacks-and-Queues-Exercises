using System;
using System.Collections.Generic;
using System.Linq;


namespace Task07_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpNumber = int.Parse(Console.ReadLine());

            Queue<string> pumpsInfo = new Queue<string>();
            for (int i = 1; i <= pumpNumber; i++)
            {
                pumpsInfo.Enqueue(Console.ReadLine());
            }

           
            
            int index = -1;

            for (int i = 0; i <= pumpNumber - 1; i++)
            {
                bool isSucses = true;
                int tank = 0;
                Queue<string> helpTemp = new Queue<string>(pumpsInfo.ToArray());

                for (int j = 0; j <= pumpNumber - 1; j++)
                {
                    int[] curentPumpInfo = helpTemp.Peek().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int fuel = curentPumpInfo[0];
                    int distance = curentPumpInfo[1];

                    tank += fuel;

                    if(tank - distance < 0)
                    {
                        isSucses = false;
                        break;
                    }
                    else
                    {
                        helpTemp.Enqueue(helpTemp.Dequeue());
                        tank -= distance;
                    }
                }

                if(isSucses)
                {
                    index = i;
                    break;
                }

                pumpsInfo.Enqueue(pumpsInfo.Dequeue());
            }
            
            
            if(index >=0)
            {
                Console.WriteLine(index);
            }
            
        }
    }
}
