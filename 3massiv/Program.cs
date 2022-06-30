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

            if (localArray.Length > 1)
            {
                if (localArray[0] > localArray[1])
                {
                    Console.Write(localArray[0] + " ");
                }

                for (int i = 1; i < localArray.Length - 1; i++)
                {
                        if (localArray[i] > localArray[i - 1] && localArray[i] > localArray[i + 1])
                        {
                            Console.Write(localArray[i] + " ");
                        }
                }
                if (localArray[localArray.Length - 1] > localArray[localArray.Length - 2])
                {
                    Console.Write(localArray[localArray.Length - 1]);
                }
            }
            else
            {
                Console.WriteLine(localArray[0]);
            }
        }
    }
}
