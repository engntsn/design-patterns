using Prototype;

var car = new Car("Ford", "2020", "Kuga");
var prototype = new Car.CarPrototype(car);

var newCar1 = prototype.Clone();
var newCar2 = prototype.Clone();
var newCar3 = prototype.Clone();

 
