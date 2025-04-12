using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class Station : Entity<Guid>
    {

        public Guid StationId { get; }

        public StationName StationName { get; private set; }

        public Guid RouteId { get; private set; }

        public Guid TariffZone { get; private set; }

        public Enum StationStatus { get; private set; }

        public Station(Guid stationId, StationName stationName, Guid routeId, Guid tariffZone, Enum stationStatus): base(stationId)
        {
            StationName = stationName;
            RouteId = routeId;
            TariffZone = tariffZone;
            StationStatus = stationStatus;
        }



        public void SetStationName(StationName stationName)
        {

        }
        public void SetRouteId(Guid routeId)
        {

        }

        public void AddStationStatus(Enum stationStatus)
        {

        }
        public void SetTariffZone(Guid tariffZone)
        {

        }




    }
}
