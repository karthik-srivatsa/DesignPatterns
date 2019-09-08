using System;

namespace AbstractFactory
{
    class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind coffee beans! Boil water of {amount} ml, add cream and sugar, enjoy!");
            return new Coffee();
        }
    }
}