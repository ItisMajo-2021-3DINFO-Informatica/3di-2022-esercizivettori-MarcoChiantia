using System;

namespace ChiantiaVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[400];
            Random generatore = new Random();
            for ( int i= 0; i < 400; i++) 
            {     
                numeri[i] = generatore.Next(1, 101);
                Console.WriteLine(numeri[i]);
            }

        }
    }
}
