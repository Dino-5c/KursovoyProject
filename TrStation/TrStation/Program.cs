using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities;
using TrStation.Domain.TrainStation.ValueObjects;

namespace TrStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Administrator administrator_1 = new(Guid.NewGuid(), new LastName("LastName"), new FirstName("FirstName"));

            Buyer buyer1 = new(Guid.NewGuid(), new LastName("LastName2"), new FirstName("FirstName2"));

            administrator_1.CreateRoute(new RoName("South"));

            Console.WriteLine($"{administrator_1.Id} {administrator_1.AdministratorLastName}    {administrator_1.AdministratorFirstName}" );

            Console.WriteLine($"{buyer1.Id} {buyer1.LastName}    {buyer1.FirstName} ");
        }
    }
}
