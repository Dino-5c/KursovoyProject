using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities.Base;
using TrStation.Domain.TrainStation.ValueObjects;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class Buyer(Guid id, LastName buyerLastName, BuyerFirstName buyerFirstName) : Entity<Guid>(id)
    {
        public LastName LastName { get; private set; } = buyerLastName ?? throw new ArgumentNewValueException(nameof(buyerLastName));

        public FirstName FirstName { get; private set; } = buyerFirstName ?? throw new ArgumentNewValueException(nameof(buyerFirstName)); //


        internal bool ChangeLastName(LastName newBuyerLastName)
        {
            if (LastName == newBuyerLastName) return false;
            LastName = newBuyerLastName;
            return true;
        }

        internal bool ChangeFirstName(BuyerFirstName newBuyerFirstName)
        {
            if (FirstName == newBuyerFirstName) return false;
            FirstName = newBuyerFirstName;
            return true;
        }


    }
}
