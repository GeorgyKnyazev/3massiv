using System;

namespace _3massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumberInRandom = 100;
            int minNumberInRandom = 10;
            int[] localArray = new int[30];
            
            for (int i = 0; i < localArray.Length; i++)
            {
                localArray[i] = random.Next(minNumberInRandom,maxNumberInRandom);
                Console.Write(localArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < localArray.Length - 1; i++)
            {
                if (i == 0)
                {
                    if (localArray[i] > localArray[i + 1])
                    {
                        Console.Write(localArray[i] + " ");
                    }
                }
                else if (i > 0 && i < localArray.Length - 1)
                {
                    if (localArray[i] > localArray[i - 1] && localArray[i] > localArray[i + 1])
                    {
                        Console.Write(localArray[i] + " ");
                    }
                }
                else if (i == localArray.Length - 1)
                {
                    if(localArray[i] > localArray[i - 1])
                    {
                        Console.Write(localArray[i]);
                    }
                }
            }
        }
    }
}
