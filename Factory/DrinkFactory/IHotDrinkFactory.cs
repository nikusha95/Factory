namespace Factory.DrinkFactory;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}