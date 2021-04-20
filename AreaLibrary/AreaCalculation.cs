using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public static class Area
    {
        const double pi = 3.14;
        public static void AreaCalculation(double r)
        {
            double s = r * pi;
            Console.WriteLine($"Площадь круга равна {s}");
        }
        public static void AreaCalculation(double r, double a, double b)
        {
            double p = (a + b + r) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - r));
            Console.WriteLine($"Площадь треугольника равна {s}");

            double hypo, leg1, leg2;
            if (r > a)
            {
                if (r > b)
                {
                    hypo = r;
                    leg1 = a;
                    leg2 = b;
                }
                else
                {
                    hypo = b;
                    leg1 = a;
                    leg2 = r;
                }
            }
            else if (b > a)
            {
                hypo = b;
                leg1 = a;
                leg2 = r;
            }
            else
            {
                hypo = a;
                leg1 = b;
                leg2 = r;
            }
            if (hypo * hypo == leg1 * leg1 + leg2 * leg2)
                Console.WriteLine("Треугольник прямоугольный");
            else
                Console.WriteLine("Треугольник не прямоугольный");
        }
    }
}
