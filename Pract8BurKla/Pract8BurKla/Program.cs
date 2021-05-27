using System;

namespace Pract8BurKla
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int[,] m = new int[10, 10];
                int max = Int32.MinValue;
                int str = 0;
                int stlb = 0;
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        m[i, j] = rnd.Next(1, 99);
                        if (m[i, j] > max && i == j)
                        {
                            max = m[i, j];
                            str = i;
                            stlb = j;
                        }
                        Console.Write("\t" + m[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Максимальный элемент диагонали : " + max);
                Console.WriteLine("Координаты максимального элемента ({0}:{1})", str + 1, stlb + 1);
                Console.WriteLine("Сумма столбов: ");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        sum += m[j, i];
                    }
                    Console.Write("\t" + sum);
                    sum = 0;
                }

                Console.ReadKey();
            }
    }
}
