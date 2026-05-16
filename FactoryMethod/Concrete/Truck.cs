using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;

// Somut Ürün 1
public class Truck : ITransport
{
    public void Deliver() => Console.WriteLine("Kutu kamyon ile kara yolundan teslim ediliyor.");
}