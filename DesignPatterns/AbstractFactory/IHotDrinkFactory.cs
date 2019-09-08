using System.Text;

namespace AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
    
}