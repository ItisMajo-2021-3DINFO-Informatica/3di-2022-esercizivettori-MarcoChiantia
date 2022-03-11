using System;

namespace ChiantiaVettori2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[100];
            Random generatore = new Random();
            for (int i = 0; i < 100; i++)
            {
                numeri[i] = generatore.Next(1, 101);
                if (numeri[i] >= 50)
                {
                    Console.WriteLine(numeri[i]);
                }
            }
        }
    }
}
