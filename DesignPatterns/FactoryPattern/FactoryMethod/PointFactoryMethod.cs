using System;

namespace FactoryPattern.FactoryMethod
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

        //Factory method
        public static Point CartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        //Factory method
        public static Point PolarPoint(double row, double theta)
        {
            return new Point(row * Math.Cos(theta), row * Math.Sin(theta));
        }
    }
}
