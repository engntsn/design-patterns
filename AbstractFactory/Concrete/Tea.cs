namespace AbstractFactory.Concrete;

public class Tea : IBeverage
{
    public void Prepare()
    {
        Console.WriteLine("Tea Preparing!");
    }
}