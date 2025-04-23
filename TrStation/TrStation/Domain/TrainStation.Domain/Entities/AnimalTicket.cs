using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Enums;
using TrainStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class AnimalTicket : Ticket
    {

        public TicketTypeNaming Tickettype { get; }

        public PriceProcent PriceProcent { get; private set; }

        public AnimalTicket(Guid ticketId, DateTime buyDate, Station startStation, Station endStation, Buyer buyerId , TicketTypeNaming ticketType, PriceProcent priceProcent) : base(ticketId, buyDate, startStation, endStation, buyerId, ticketType )
        {

        }

        public bool SetPriceProcent(PriceProcent priceProcent)
        {
            if (PriceProcent == priceProcent) return false;
            PriceProcent = priceProcent;
            return true;
        }

    }
}
