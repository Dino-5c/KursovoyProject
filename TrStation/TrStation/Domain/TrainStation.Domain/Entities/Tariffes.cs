using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{

    public class Tariffes : Entity<Guid>
    {
        public Guid TariffId { get; }

        public TMoney Price { get; private set; }

        public int Distance { get; private set; }


        public Tariffes(Guid tariffId, TMoney money, int distance): base(tariffId)
        {
            Price = money;
            Distance = distance;
        }

        public void SetPrice(TMoney money)
        {

        }

        public void SetDistance(int distance) 
        { 

        }


    }
}
