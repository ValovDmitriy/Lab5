using System;

namespace Lab5_6
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
                    Console.WriteLine("Заполните матрицу NxN:");
                    int[,] matrix = new int[poriadok, poriadok];
                    for (int i = 0; i < poriadok; i++)
                    {
                        for (int j = 0; j < poriadok; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                            
                        }
                    }
                    for (int i = 0; i < poriadok; i++)
                    {
                        for (int j = 0; j < poriadok; j++)
                        {
                            
                            Console.Write("{0} ", matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                
                for (int i = 0; i < poriadok; i++)
                {
                    int summJ = 0;
                    for (int j = 0; j < poriadok; j++)
                    {
                        summJ += matrix[i, j];
                        
                    }
                    Console.WriteLine(summJ);
                }

                for (int j = 0; j < poriadok; j++)
                {
                    int summI = 0;
                    for (int i = 0; i < poriadok; i++)
                    {
                        summI += matrix[i, j];

                    }
                    Console.WriteLine(summI);
                }

                int summD1 = 0;
                int summD2 = 0;
                for (int i = 0; i < poriadok; i++)
                {
                    summD1 += matrix[i, i];
                    summD2 += matrix[i, poriadok - i - 1];
                }
                Console.WriteLine(summD1);
                Console.WriteLine(summD2);

                if (summI == summJ==summD1==SummD2)
                {

                }


            }
            }
        
    }
}
