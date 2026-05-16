using BuilderPattern;


var sportCar = new CarDirector().BuildSportCar();
var classicCar = new CarDirector().BuildSportCar();

Console.WriteLine(sportCar.Color); //Red
sportCar.Color = "Green"; 
Console.WriteLine(sportCar.Color);//Green

Console.WriteLine(classicCar.Hp);
classicCar.Hp = 133;
Console.WriteLine(classicCar.Hp);
