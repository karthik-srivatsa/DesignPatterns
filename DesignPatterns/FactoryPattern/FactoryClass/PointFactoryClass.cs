using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.FactoryClass
{
    class Point
    {
        private double x;
        private double y;
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
            public static Point CartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point PolarPoint(double row, double theta)
            {
                return new Point(row * Math.Cos(theta), row * Math.Sin(theta));
            }
        }

    }
}
