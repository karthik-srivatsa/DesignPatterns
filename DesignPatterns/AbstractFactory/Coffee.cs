using System;

namespace AbstractFactory
{
    class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffee is sensational");
        }
    }
}
