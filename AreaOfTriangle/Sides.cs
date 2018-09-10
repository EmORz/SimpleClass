using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfTriangle
{
    class Sides
    {
        private double a;
        private double b;
        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Sides()
        {

        }
        public Sides(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Sides(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double WithThreeValue (double a , double b, double c)
        {
            var semiperimeter = 0.5 * (a + b + c);
            var area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return area;
        }
        public double WithTwoValueAH(double b, double h)
        {
            var area = (a * h) * 0.5;
            return area;
        }
        public double WithThreeValueAHD(double b, double h, double degree)
        {
            var temp = (Math.PI / 180) * degree;
            double area = (h * b * Math.Sin(temp)) * 1.0 / 2;
            return area;
        }

    }
}
