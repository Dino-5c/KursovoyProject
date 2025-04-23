using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Enums;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class Ticket : Entity<Guid>
    {
        // const decimal FullProcent = 1.00m;

        public DateTime BuyDate { get; }

        public Station StartStation { get; private set; }

        public Station EndStation { get; private set; }

        public Buyer Buyer { get; }

        public Money Price { get; private set; }

        public TicketTypeNaming TicketType { get; private set; } 

        public PriceProcent PriceProcent { get; private set; }

        public bool IsAnimal => TicketType == TicketTypeNaming.Animal;

        public bool IsBuggage => TicketType == TicketTypeNaming.Buggage;

        public bool IsLgot => TicketType == TicketTypeNaming.Lgot;

        public bool IsFull => TicketType == TicketTypeNaming.Full;

        /* private readonly ICollection<Route> _routes = []; */

        /// <summary>
        /// Конструктор создания Билета
        /// </summary>
        /// <param name="id">Номер билета</param>
        /// <param name="buyDate">Дата покупки билета</param>
        /// <param name="startStation">Начальная станция</param>
        /// <param name="endStation">Конечная станция</param>
        /// <param name="buyerId">Покупатель</param>
        /// <exception cref="CoincidenceOfStartAndEndStationException">Исключение, которое срабатывает, если начальная и конечная станции совпадают.</exception>
        protected Ticket(Guid id, DateTime buyDate, Station startStation, Station endStation, Buyer buyer, TicketTypeNaming ticketType) : base(id) 
        {
            BuyDate = buyDate; // Проверка даты, времени покупки билета

            if (startStation.Id == endStation.Id) throw new CoincidenceOfStartAndEndStationException(this, startStation, endStation); // Нужно?

            // Сделать: Проверка, что станции находятся на одном маршруте
            if(startStation.Route.Id != endStation.Route.Id)
                throw new StationsOnDifferentRoutesException(this, startStation, endStation);
            
            // StartStation = startStation ;
            if(!SetStartStation(startStation))      
                throw new NotChangedStartStationNameException(this, startStation);

            
            if(!SetEndStation(endStation)) //
                throw new NotChangedEndStationNameException(this, endStation);
            
            TicketType = ticketType;
            Buyer = buyer ?? throw new ArgumentNullValueException(nameof(buyer));
            // Добавить в список билетов
            PriceProcent = SetPriceProcent();
            Price = (endStation.TariffZone.Price - startStation.TariffZone.Price) * PriceProcent;
        }

        public PriceProcent SetPriceProcent(/*TicketTypeNaming ticketType*/)
        {
            PriceProcent priceProcent = new PriceProcent(1.0m);
            // if (IsFull) { priceProcent = new PriceProcent(1.00m); }
            if (IsBuggage) { priceProcent = priceProcent * 2 ; }
            else if (IsAnimal) { priceProcent = priceProcent * 2; }
            else if (IsLgot) { priceProcent = priceProcent / 2; }
            else { PriceProcent = priceProcent * 1; }
            return priceProcent;
        }


        // В конструкторе создаём Guid номер билета, так как создаём билет здесь, когда покупаем а 
        public Ticket(DateTime buyDate, Station startStation, Station endStation, Buyer buyer, TicketTypeNaming ticketType)
            :this(Guid.NewGuid(), buyDate, startStation, endStation, buyer, ticketType)
        {

        }

        /// <summary>
        /// Изменение номера начальной станции (откуда отправляется поезд).
        /// </summary>
        /// <param name="startStation">Номер начальной станции.</param>
        /// <returns>Возвращается true, если получилось изменить номер начальной станции. В другом случае возвращается false</returns>
        public bool SetStartStation(Station startStation) 
        {
            if (!startStation.IsActive)
                throw new BuyTicketOnFrozenStationException(this, startStation);
            if (StartStation == startStation) return false;
            StartStation = startStation ?? throw new ArgumentNullValueException(nameof(startStation));
            return true;
        }

        /// <summary>
        /// Изменение номера конечной станции (до куда идёт поезд).
        /// </summary>
        /// <param name="endStation">Номер конечной станции.</param>
        /// <returns>Возвращается true, если получилось изменить номер конечной станции. В другом случае возвращается false</returns>
        public bool SetEndStation(Station endStation)
        {
            if (EndStation == endStation) return false;
            if (!endStation.IsActive)
                throw new BuyTicketOnFrozenStationException(this, endStation);
            if (EndStation.Id == StartStation.Id)
                throw new CoincidenceOfStartAndEndStationException(this, this.StartStation, endStation);
            EndStation = endStation ?? throw new ArgumentNullValueException(nameof(endStation));
            return true;
        }
    }
}
