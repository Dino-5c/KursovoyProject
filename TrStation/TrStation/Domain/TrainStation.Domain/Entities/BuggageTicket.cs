using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class BuggageTicket : Ticket<>
    {
        public Tickettypes Tickettype { get; }

        public Procents PriceProcent { get; private set; }

        public BuggageTicket(Guid ticketId, DateTime buyDate, Guid startStation, Guid endStation, Guid buyerId, Tickettypes tickettype, Procents priceProcent) : base(ticketId, buyDate, startStation, endStation, buyerId)
        {
        }

        public void SetPriceProcent(Procents priceProcent)
        {

        }
    }
}
