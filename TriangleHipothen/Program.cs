using System;

namespace TriangleHipothen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която по дадени два катета намира хипотенузата на правоъгълен триъгълник. Реализирайте въвеждане на
             * дължините на катетите от стандартния вход, а за пресмятането на хипотенузата използвайте методи на класа Math. */
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var hipothenuse = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b, 2));
            Console.WriteLine(hipothenuse);
        }
    }
}
