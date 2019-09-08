using System;

namespace AbstractFactory
{
    class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Tea is nice");
        }
    }
}
