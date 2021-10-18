using System;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}",array[i]);
            }
            Console.WriteLine();
            for (int i = 5; i < 10; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
    }
}
