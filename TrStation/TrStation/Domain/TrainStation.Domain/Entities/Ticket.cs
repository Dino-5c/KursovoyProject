using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    abstract class Ticket : Entity<Guid>
    {
        private Guid Id { get; }

        public DateTime BuyDate { get; }

        public Guid StartStation { get; private set; }

        public Guid EndStation { get; private set; }

        public Guid BuyerId { get; }

        public Ticket(Guid id, DateTime buyDate, Guid startStation, Guid endStation, Guid buyerId) : base(id) 
        {
            BuyDate = buyDate;
            StartStation = startStation;
            EndStation = endStation;
            BuyerId = buyerId;
        }

        public void SetStartStation(Guid startStation)
        {

        }

        public void SetEndStation(Guid endStation)
        {

        }
    }
}
