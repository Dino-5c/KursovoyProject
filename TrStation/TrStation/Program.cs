using System.Linq.Expressions;
using TrainStation.Domain.TrainStation.Domain.Enums;
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

            Administrator administrator_1 = new(new LastName("LastName"), new FirstName("FirstName"));

            Buyer buyer1 = new(new LastName("LastName2"), new FirstName("FirstName2"));

            Route route1 = administrator_1.CreateRoute(new RoName("Направление Южное"));

            Route route2 = administrator_1.CreateRoute(new RoName("Направление Западное"));

            Route route3 = administrator_1.CreateRoute(new RoName("Направлеие Кузбасс"));

            var tarifZone0 = administrator_1.CreateTariffZone(new TarifZoneNames(0), new Money(40m), new Distance(0));
            var tarifZone1 = administrator_1.CreateTariffZone(new TarifZoneNames(1), new Money(40m), new Distance(5));
            var tarifZone2 = administrator_1.CreateTariffZone(new TarifZoneNames(2), new Money(40m), new Distance(15));
            var tarifZone3 = administrator_1.CreateTariffZone(new TarifZoneNames(3), new Money(52m), new Distance(25));
            var tarifZone4 = administrator_1.CreateTariffZone(new TarifZoneNames(4), new Money(72m), new Distance(35));
            var tarifZone5 = administrator_1.CreateTariffZone(new TarifZoneNames(5), new Money(92m), new Distance(45));

            Console.WriteLine($"{administrator_1.Id} {administrator_1.AdministratorLastName}    {administrator_1.AdministratorFirstName}" );

            Console.WriteLine($"{buyer1.Id} {buyer1.LastName}    {buyer1.FirstName} ");


            var station1 = administrator_1.CreateStation(new StationName("Новосибирск-Главный (Западное)"), route2, tarifZone0, StationStatus.Active);
            var station2 = administrator_1.CreateStation(new StationName("Правая Обь"), route2, tarifZone1, StationStatus.Active);
            var station3 = administrator_1.CreateStation(new StationName("Левая Обь"), route2, tarifZone1, StationStatus.Active);
            var station4 = administrator_1.CreateStation(new StationName("Жилмассив"), route2, tarifZone2, StationStatus.Active);
            var station5 = administrator_1.CreateStation(new StationName("Нск-Западный"), route2, tarifZone2, StationStatus.Active);
            var station6 = administrator_1.CreateStation(new StationName("Западная площадка"), route2, tarifZone2, StationStatus.Active);
            var station7 = administrator_1.CreateStation(new StationName("Ипподром"), route2, tarifZone2, StationStatus.Active);
            var station8 = administrator_1.CreateStation(new StationName("Обь"), route2, tarifZone3, StationStatus.Active);
            var station9 = administrator_1.CreateStation(new StationName("Аэрофлот"), route2, tarifZone3, StationStatus.Active);
            var station10 = administrator_1.CreateStation(new StationName("Павино"), route2, tarifZone3, StationStatus.Active);
            var station11 = administrator_1.CreateStation(new StationName("Сады"), route2, tarifZone3, StationStatus.Active);
            var station12 = administrator_1.CreateStation(new StationName("О. п. 3307км."), route2, tarifZone4, StationStatus.Active);
            var station13 = administrator_1.CreateStation(new StationName("Чик"), route2, tarifZone4, StationStatus.Active);
            var station14 = administrator_1.CreateStation(new StationName("О. п. 3293км."), route2, tarifZone5, StationStatus.Active);
            var station16 = administrator_1.CreateStation(new StationName("Новосибирск-Главный (Южное)"), route1, tarifZone0, StationStatus.Active);
            var station15 = administrator_1.CreateStation(new StationName("Центр"), route1, tarifZone1, StationStatus.Active);


            Ticket ticket1 = buyer1.BuyTicket(station1, station10, TicketTypeNaming.Full);
            /* if(station1.TariffZone.TariffName > station3.TariffZone.TariffName)
            {
                var tmp = station1;
                station1 = station3;
                station3 = station1;
            } */
            Console.WriteLine($"{ticket1.Id} {ticket1.BuyDate} {ticket1.Buyer.FirstName} {ticket1.StartStation.StationName} {ticket1.EndStation.StationName} {ticket1.Price} {ticket1.TicketType}");

            Ticket ticket2 = buyer1.BuyTicket(station14, station4, TicketTypeNaming.Full);
            /* if (station14.TariffZone.TariffName > station4.TariffZone.TariffName)
            {
                var tmp = station14;
                station14 = station4;
                station4 = station14;
            } */
            Console.WriteLine($"{ticket2.Id} {ticket2.BuyDate} {ticket2.Buyer.FirstName} {ticket2.StartStation.StationName} {ticket2.EndStation.StationName} {ticket2.Price} {ticket2.TicketType}");




            IReadOnlyCollection<Ticket> _tickets = buyer1.BuyerTickets;
            foreach(var ticket in _tickets)
            {
                Console.WriteLine(ticket.Id);
            }
            MetodsOfAdministrator(administrator_1, route2, tarifZone5, StationStatus.Frozen);
            Console.WriteLine();
            // administrator_1
            try
            {
                Ticket ticket9 = buyer1.BuyTicket(station6, station11, TicketTypeNaming.Full);
                Ticket ticket3 = BuyTickets(buyer1, administrator_1);
                Console.WriteLine($"{ticket3.Id} {ticket3.BuyDate} {ticket3.Buyer.FirstName} {ticket3.StartStation.StationName} {ticket3.EndStation.StationName} {ticket3.Price} {ticket3.TicketType}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }

        }


        public static Ticket BuyTickets(Buyer buyer, Administrator administrator)
        {

            Console.WriteLine("Выбор начальной станции ");
                Station s1 = ChooseStationn(administrator);
            Console.WriteLine("Выбор конечной станции ");
                Station s2 = ChooseStationn(administrator);
            // TicketTypeNaming.Full;
            Console.WriteLine("Выбор Типа билета ");
            TicketTypeNaming ticketType1 = ChooseTicketType();
                Ticket ticket = buyer.BuyTicket(s1, s2, ticketType1);
                Console.WriteLine("aa"); return ticket;
                


        }

        public static void MetodsOfAdministrator(Administrator administrator, Route route, Tariffes tariffZone, StationStatus stationStatus)
        {
            //int tmp = 0;

            //Console.WriteLine("Выберите");
            //while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < 0 || tmp > 5)
            //{
            //    Console.WriteLine("Error! Выберите другое значение из номеров станций.");
            //}

            AddEntity(administrator, route, tariffZone, stationStatus);

        }

        public static void AddEntity(Administrator administrator, Route route, Tariffes tariffZone, StationStatus stationStatus)
        {
            Station station = administrator.CreateStation(new StationName("Ст. 12-"), administrator.Routes.ToArray()[1], tariffZone, stationStatus);
            foreach(var i in administrator.Stations)
            {
                Console.WriteLine(i.StationName);
            }
            Console.WriteLine();
            administrator.DeleteStation(station, route);
            foreach (var i in administrator.Stations)
            {
                Console.WriteLine(i.StationName);
            }

            Console.WriteLine();
        }

        public static Station ChooseStationn(Administrator administrator1)
        {
            var stationss2 = administrator1.Stations.ToArray();
            /* foreach(var st in administrator1.Stations) */
            /* { */
            /* Console.WriteLine(st.StationName); */
            /* } */

            for (int i = 0; i < stationss2.Length; i++)
            {
                Console.Write(i + "\t");
                Console.WriteLine(stationss2[i].StationName); 

            }

            int tmp = 0;

            Console.WriteLine("Выберите");
            while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < 0 || tmp > stationss2.Length)
            {
                Console.WriteLine("Error! Выберите другое значение из номеров станций .");
            }


            for (int i = 0; i < stationss2.Length; i++)
            {
                if (tmp == i)
                {
                    Console.WriteLine("Выбрана станция " + stationss2[i].StationName);
                    return stationss2[i];
                }               
            }
            // Если станция не обнаружено, возвращаем первую станцию в коллекции
            Console.WriteLine( "Выбрана станция " + stationss2[0].StationName);
            return stationss2[0];
        }

        public static TicketTypeNaming ChooseTicketType()
        {
            int tmp = 0;

            string[] types = ["Полный", "Льготный", "С животными", "С багажом"];

            for(int i = 0; i < types.Length; i++)
            {
                Console.WriteLine(i + " " + types[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Выберите тип билетов");
            while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < 0 || tmp > 3)
            {
                Console.WriteLine("Error! Выберите другое значение из номеров [0; 3]");
            }

            if (tmp == 0) return TicketTypeNaming.Full;
            else if (tmp == 1) return TicketTypeNaming.Lgot;
            else if (tmp == 2) return TicketTypeNaming.Animal;
            else if (tmp == 3) return TicketTypeNaming.Buggage;
            else return TicketTypeNaming.Full;

        }

    }
}


