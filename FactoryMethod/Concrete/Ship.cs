using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete;


// Somut Ürün 2
public class Ship : ITransport
{
    public void Deliver() => Console.WriteLine("Konteyner gemi ile deniz yolundan teslim ediliyor.");
}