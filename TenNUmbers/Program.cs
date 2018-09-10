using System;

namespace TenNUmbers
{
    class Program
    {
        static Random rnd = new Random();
        static int counter = 0;
        static void Main(string[] args)
        {
            // Напишете програма, която генерира и принтира на конзолата 10 случайни числа в интервала[100, 200].
           
            for (int i = 0; i < 10; i++)
            {
                counter++;
                int num = rnd.Next(100, 200);
                Console.WriteLine($"{counter} "+num);
            }
        }
    }
}
