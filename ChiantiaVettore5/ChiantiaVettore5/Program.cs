using System;

namespace ChiantiaVettore5
{
    class Program
    {
        static void Main(string[] args)
        {
            
             double percentuale = 0;
            double percentualefin = 0;
            int[] numeri = new int[1000];
            Random generatore = new Random();
            for (int i = 0; i <1000; i++)
            {
                numeri[i] = generatore.Next(1, 251);
                Console.WriteLine(numeri[i]);
                if (numeri[i] < 175)
                {
                    percentuale = percentuale + 1;
                    percentualefin = percentuale / 100;
                    
                }
            }
            Console.WriteLine("i numeri sotto 175 sono il" + percentualefin + "%");
        }
    }
}
