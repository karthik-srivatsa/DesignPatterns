using AbstractFactory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bad Initialization.
            var point1 = new Problem.Point(1.0, 1.0, CoordinayteSystem.Cartesian);
            //or
            var point2 = new Problem.Point(1.0, 1.0, CoordinayteSystem.Polar);

            //Factory Method 
            var point3 = FactoryMethod.Point.CartesianPoint(1.0, 1.0);
            var point4 = FactoryMethod.Point.PolarPoint(1.0, 1.0);

            //Factory Class
            var point5 = FactoryClass.Point.Factory.CartesianPoint(1.0, 1.0);
            var point6 = FactoryClass.Point.Factory.PolarPoint(1.0, 1.0);


            //Abstract Factory
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(AvailableDrinks.Coffee, 50);
            drink.Consume();
        }
    }
}
