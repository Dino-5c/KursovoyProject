using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Route route1 = new Route(new Guid("22221111333344445555777788889999"), new RoName("НоГл-Та"));

            Tariffes tariffZone1 = new Tariffes(new Guid("65794747356364444624698767895678"), new TarifZoneNames("Первая тарифная зона"), new Money(40), new Distance(5));
            Station station1 = new Station(new Guid("11112222333344445555666677778888"), new StationName("Н-Г"), route1, tariffZone1);

            Console.WriteLine(tariffZone1.Id + " " + tariffZone1.TariffName + " " + tariffZone1.Price + " " + tariffZone1.Distance);
            Console.WriteLine(station1.Id + " " + station1.StationName + " " + station1.Route + " " + station1.TariffZone);
        }
    }
}
