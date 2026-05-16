namespace BuilderPattern;

public class CarBuilder
{
    private Car _car;

    public CarBuilder()
    {
        _car = new Car();
    }

    public CarBuilder SetGear(string gear)
    {
        _car.Gear = gear;
        return this;
    }
    
    public CarBuilder SetEnginePower(int enginePower)
    {
        _car.Hp = enginePower;
        return this;
    }
    
    public CarBuilder SetColor(string color)
    {
        _car.Color = color;
        return this;
    }
    
    public Car Build()
    {
        return _car;
    }

}