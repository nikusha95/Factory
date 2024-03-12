namespace Factory.DrinkFactory;

public class Coffee : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("Coffee Sample");
    }
}