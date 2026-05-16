namespace AbstractFactory.Concrete;

public class TeaFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    {
       return new Tea();
    }
}