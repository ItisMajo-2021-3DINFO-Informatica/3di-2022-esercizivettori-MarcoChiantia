using System;

namespace ChiantiaVettori4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[100];
            Random generatore = new Random();
            int min = 4000;
            int max = 0;
            for (int i = 0; i <100; i++)
            {
                numeri[i] = generatore.Next(1000, 3001);
                Console.WriteLine(numeri[i]);

                if(max < numeri[i])
                {
                    max = numeri[i];
                }
                if (min > numeri[i])
                {
                    min = numeri[i];
                }
            }
            Console.WriteLine("il minimo è; " + min);
            Console.WriteLine("il massimo è; " + max);
        }
    }
}
