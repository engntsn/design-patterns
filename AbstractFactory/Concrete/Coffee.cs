namespace AbstractFactory.Concrete;

public class Coffee : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Coffee Preparing!");
    }
}