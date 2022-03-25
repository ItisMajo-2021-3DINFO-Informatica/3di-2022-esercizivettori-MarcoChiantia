using System;

namespace chiantia_gol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gol = new int[8];
            int min = 1000;
            int max = -1;
            double media = 0;
            double somma = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Gol giornata " + (i + 1) + ": ");
                gol[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"gol[{i}]={gol[i]}");
            }
            for (int i = 0; i < 8; i++)
            {
                if (min > gol[i])
                {
                    min = gol[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (max < gol[i])
                {
                    max = gol[i];
                }
            }
            for (int i = 0; i < 8; i++)
            {
                somma = somma + gol[i];
                media = somma / 8;

            }
            Console.WriteLine($"il minimo è " + min);
            Console.WriteLine($"il massimo è " + max);
            Console.WriteLine($"la media di gol a giornata è" + media);
        }
    }
}
