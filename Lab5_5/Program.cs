using System;

namespace Lab5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число N:");
            int poriadok = Convert.ToInt32(Console.ReadLine());
            if (poriadok <= 0)
            {
                return;
            }
            else 
            {
                int[,] matrix = new int[poriadok, poriadok];
                for (int i = 0; i < poriadok; i++)
                {
                    for (int j = 0; j < poriadok; j++)
                    {
                        matrix[i, j] = 1 - (i + j) % 2;
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
