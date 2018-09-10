using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var first = new Sides(a, b);
            var ans = first.WithTwoValueAH(a, b);
            Console.WriteLine(ans);
            //
            var a1 = double.Parse(Console.ReadLine());
            var b1 = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var second = new Sides(a1, b1, c);
            var ans1 = second.WithThreeValue(a1, b1, c);
            Console.WriteLine(ans1);
            //
            var a2 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var c1 = double.Parse(Console.ReadLine());
            var third = new Sides(a2, b2, c1);
            var ans2 = third.WithThreeValueAHD(a2, b2, c1);
            Console.WriteLine(ans2);
        }
    }
}
