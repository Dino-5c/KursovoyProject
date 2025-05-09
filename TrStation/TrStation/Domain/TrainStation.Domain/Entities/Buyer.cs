using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Enums;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;
using TrStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class Buyer(Guid id, LastName buyerLastName, FirstName buyerFirstName) : Entity<Guid>(id)
    {


        public LastName LastName { get; private set; } = buyerLastName ?? throw new ArgumentNullValueException(nameof(buyerLastName));

        public FirstName FirstName { get; private set; } = buyerFirstName ?? throw new ArgumentNullValueException(nameof(buyerFirstName)); //

        private readonly ICollection<Ticket> _buyerTickets = [];

        public IReadOnlyCollection<Ticket> BuyerTickets =>
            _buyerTickets.ToList().AsReadOnly();

        internal bool ChangeLastName(LastName newBuyerLastName)
        {
            if (LastName == newBuyerLastName) return false;
            LastName = newBuyerLastName;
            return true;
        }

        internal bool ChangeFirstName(FirstName newBuyerFirstName)
        {
            if (FirstName == newBuyerFirstName) return false;
            FirstName = newBuyerFirstName;
            return true;
        }

        public void BuyTicket(Station startStation, Station endStation, TicketTypeNaming ticketTypeNaming)
        {
            // Добавить Исключения, если переданы в параметры null
            Ticket ticket = new(DateTime.Now, startStation, endStation, this, ticketTypeNaming);
            _buyerTickets.Add(ticket);
        }

    }
}
