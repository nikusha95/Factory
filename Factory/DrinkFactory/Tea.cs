namespace Factory.DrinkFactory;

public class Tea : IHotDrink
{
    public void Consume()
    {
        Console.WriteLine("Tea Sample");
    }
}