namespace BuilderPattern;

public class Car
{

    #region Member Initilization

    public string Gear { get; set; } = "Automatic";
        public int Hp { get; set; } = 10;
        public string Color { get; set; } = "Black";

    #endregion
    
    #region Classic Constructor
    
    // public Car()
    // {
    //     Gear = "Automatic";
    //     Hp = 10;
    //     Color = "Black";
    // }
    // public string Gear { get; set; }
    // public int Hp { get; set; }
    // public string Color { get; set; }
    
    #endregion
    
    
    
}