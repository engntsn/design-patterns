namespace Prototype;

public class Car : ICloneable
{ 
    public Car(string brand, string year, string model)
    {
        Brand = brand;
        Year = year;
        Model = model;
    } 
    
    private string Brand { get; set; }
    public string Year { get; set; }
    private string Model { get; set; }
    
    public object Clone()
    {
        return new Car(Brand, Year, Model);
    }
    
    public class CarPrototype
    {
        private Car _car;

        public CarPrototype(Car car)
        {
            _car = car;
        }
        
        public Car Clone()
        {
            return (Car) _car.Clone();
        }
    }
}