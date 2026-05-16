namespace AbstractFactory.Concrete;

public class CofeeFactory : IBeverageFactory
{
    public IBeverage CreateBeverage()
    { 
        return new Coffee(); 
    }
}