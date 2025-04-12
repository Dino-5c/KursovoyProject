using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class TimeTable : Entity<Guid>
    {
        public Guid RouteId {get; }
        
        public Guid StationId { get; private set; }

        public TrainNumber NumberOfTrain { get; private set; }
        
        public DateTime TimeArrival { get; private set; }

        public TimeTable(Guid routeId, Guid stationId, TrainNumber numberOfTrain, DateTime timeArrival) : base(routeId)
        {
            StationId = stationId;
            NumberOfTrain = numberOfTrain;
            TimeArrival = timeArrival;
        }

        public void SetStationId(Guid stationId)
        {

        }

        public void SetNumberOfTrain(TrainNumber numberOfTrain)
        {

        }

    }
}
