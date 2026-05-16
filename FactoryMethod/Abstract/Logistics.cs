using FactoryMethod.Concrete;

namespace FactoryMethod.Abstract;

// Soyut Oluşturucu Sınıf
public abstract class Logistics
{
    // Factory Method: Alt sınıflar bu metodu ezerek kendi ürünlerini dönecek.
    public abstract ITransport CreateTransport();

    // Fabrika sınıfı sadece nesne üretmez, iş mantığını da yürütebilir
    public void PlanDelivery()
    {
        ITransport transport = CreateTransport();
        transport.Deliver();
    }
}

// Somut Fabrika 1 (Kara Lojistiği)
public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport() => new Truck();
}

// Somut Fabrika 2 (Deniz Lojistiği)
public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport() => new Ship();
}