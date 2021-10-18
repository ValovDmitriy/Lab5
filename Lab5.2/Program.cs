using System;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int Summ = 0;
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a>max)
                {
                    max = a;
                }
            }
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            Summ = max + min;
            Console.WriteLine(Summ);
        }
    }
}
