using AbstractFactory;
using AbstractFactory.Concrete;

Console.WriteLine("Hello, World!");

//Nesnelerin yaratılması görevini belirli bir factory class'a devreder. kendi instance almaz. 

IBeverageFactory beverageFactory;
    
beverageFactory = new CofeeFactory();
IBeverage beverage = beverageFactory.CreateBeverage();
beverage.Prepare();

beverageFactory = new TeaFactory();
beverage = beverageFactory.CreateBeverage();
beverage.Prepare();
 



 