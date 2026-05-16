namespace BuilderPattern;

public class CarDirector
{
    public Car BuildSportCar()
    {
       return new CarBuilder()
           .SetGear("Automatic")
           .SetColor("Red")
           .SetEnginePower(300)
           .Build();
    }
    
    public Car BuildClassicCar()
    {
        return new CarBuilder()
            .SetGear("Manual")
            .SetColor("Blue")
            .SetEnginePower(100)
            .Build();
    }
}