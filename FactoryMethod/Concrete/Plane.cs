using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;
 
// Somut Ürün 3
public class Plane : ITransport
{
    public void Deliver() => Console.WriteLine("Konteyner uçak ile have yolundan teslim ediliyor.");
}