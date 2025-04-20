using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Enums;
using TrainStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class BuggageTicket : Ticket
    {
        public TicketType Tickettype { get; }

        public PriceProcent PriceProcent { get; private set; }

        public Money Price { get; private set; }
        public BuggageTicket(Guid ticketId, DateTime buyDate, Station startStation, Station endStation, Buyer buyerId, TicketTypeNaming ticketType, PriceProcent priceProcent) : base(ticketId, buyDate, startStation, endStation, buyerId, ticketType)
        {
            // Искать по массиву(списку) станций нужную станцию по номеру, находить её тарифную зону, потом то же делаем со второй и вычтаем тарифные зоны
            // this.Tickettype = ticketType;
            this.PriceProcent = priceProcent;
            this.Price = (endStation.TariffZone.Price - startStation.TariffZone.Price) * priceProcent; 
        }

        public bool SetPriceProcent(PriceProcent priceProcent)
        {
            if (PriceProcent == priceProcent) return false;
            PriceProcent = priceProcent;
            return true;
        }
    }
}
