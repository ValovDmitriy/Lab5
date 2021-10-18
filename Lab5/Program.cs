using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 чисел:");
            const byte n= 7;
            float Summ = 0;
            float SrAr;
            float[] array = new float[n];
            foreach (int i in array)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Summ += array[i];
            }
            SrAr = Summ / n;
            Console.WriteLine(SrAr);
        }
    }
}
