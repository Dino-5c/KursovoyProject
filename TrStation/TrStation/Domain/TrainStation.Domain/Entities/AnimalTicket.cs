using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class AnimalTicket : Ticket
    {

        public TicketType Tickettype { get; }

        public PriceProcent PriceProcent { get; private set; }

        public AnimalTicket(Guid ticketId, DateTime buyDate, Guid startStation, Guid endStation, Guid buyerId , TicketType tickettype, PriceProcent priceProcent) : base(ticketId, buyDate, startStation, endStation, buyerId)
        {

        }

        public void SetPriceProcent(PriceProcent priceProcent)
        {

        }

    }
}
