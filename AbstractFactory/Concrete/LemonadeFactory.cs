namespace AbstractFactory.Concrete;

public class LemonadeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
        return new Lemonade();
    }
}