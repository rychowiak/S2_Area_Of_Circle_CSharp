using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class Circle
    {
        public static void CircleArea(double r, double pi)
        {
            double a = pi * r * r;
            Console.WriteLine("The area of a circle of radius {0} is: {1:0.00}", r, a);
        }
        public static double CircleCircumference(double r, double pi)
        {
            double c = 2 * pi * r;
            Console.WriteLine("The circumference of a circle of radius {0} is: {1:0.00}", r, c);
            return c;
        }

        public static void CircleDiameter(double r)
        {
            double d = 2 * r;
            Console.WriteLine("The diameter of a circle of radius {0} is: {1}", r, d);
        }
    }
}
