using System;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int t=0;
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < 20; i += 2)
            {
                    if (array[i] > 0 && array[i]%2 != 0)
                    {
                        t++;
                    }
            }
                Console.WriteLine("Количество нечетных положительных элементов на четных местах:{0}",t);
        }
    }
}
