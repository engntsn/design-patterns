using FactoryMethod.Abstract;

Console.WriteLine("Hello, World!");

Logistics logistics;

// Senaryo A: Kara taşımacılığı gerekiyor
logistics = new RoadLogistics();
logistics.PlanDelivery(); // Çıktı: Kutu kamyon ile kara yolundan teslim ediliyor.

// Senaryo B: Deniz taşımacılığı gerekiyor
logistics = new SeaLogistics();
logistics.PlanDelivery(); // Çıktı: Konteyner gemi ile deniz yolundan teslim ediliyor.
