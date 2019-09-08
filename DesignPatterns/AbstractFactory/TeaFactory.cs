using System;

namespace AbstractFactory
{
    class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put a tea bag! Boil water of {amount} ml, enjoy!");
            return new Tea();
        }
    }
}