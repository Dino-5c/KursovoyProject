using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class BuggageTicket : Ticket
    {
        public TicketType Tickettype { get; }

        public PriceProcent PriceProcent { get; private set; }

        public Money Price { get; private set; }
        public BuggageTicket(Guid ticketId, DateTime buyDate, Guid startStation, Guid endStation, Guid buyerId, TicketType tickettype, PriceProcent priceProcent) : base(ticketId, buyDate, startStation, endStation, buyerId)
        {
            this.Tickettype = tickettype;
            this.PriceProcent = priceProcent;
            this.Price = (endStation.tariffZone - startStation.tariffZone) * priceProcent; 
        }

        public void SetPriceProcent(PriceProcent priceProcent)
        {

        }
    }
}
