using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Problem
{
    class Point
    {
        private double x;
        private double y;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="coordinayteSystem"></param>
        public Point(double a, double b, CoordinayteSystem coordinayteSystem = CoordinayteSystem.Cartesian)
        {
            switch(coordinayteSystem)
            {
                case CoordinayteSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case CoordinayteSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentException();

            }
            
        }

    }
}
