namespace AbstractFactory.Concrete;

public class Lemonade : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Lemonade Preparing!");
    }
}