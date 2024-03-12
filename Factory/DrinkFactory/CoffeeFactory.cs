namespace Factory.DrinkFactory;

public class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        Console.WriteLine($"Preparing {amount}");

        return new Coffee();
    }
}