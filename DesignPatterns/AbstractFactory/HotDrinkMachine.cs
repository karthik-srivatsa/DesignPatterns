using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        private Dictionary<AvailableDrinks, IHotDrinkFactory> factories = new Dictionary<AvailableDrinks, IHotDrinkFactory>();
        public HotDrinkMachine()
        {
            foreach (AvailableDrinks drinks in Enum.GetValues(typeof(AvailableDrinks)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType($"AbstractFactory.{drinks}Factory"));
                factories.Add(drinks, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrinks drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
    
}