using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Enums;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class Station : Entity<Guid>
    {

        public Guid StationId { get; }

        public StationName StationName { get; private set; }

        public Guid RouteId { get; private set; }

        public Guid TariffZone { get; private set; }

        public StationStatus StationStatus { get; private set; }


        public bool IsActive => StationStatus == StationStatus.Active;

        public bool IsFrozen => StationStatus == StationStatus.Frozen;

        public Station(Guid stationId, StationName stationName, Guid routeId, Guid tariffZone, StationStatus stationStatus): base(stationId)
        {
            StationName = stationName ?? throw new ArgumentNullValueException(nameof(stationName));
            RouteId = routeId;
            TariffZone = tariffZone;
            StationStatus = stationStatus;
        }


        /// <summary>
        /// Изменение названия станции.
        /// </summary>
        /// <param name="stationName">Название станции.</param>
        /// <returns>Возвращается true, если получилось изменить название станции. В другом случае возвращается false</returns>
        internal bool SetStationName(StationName stationName)
        {
            if (StationName == stationName) return false;
            StationName = stationName;
            return true;
        }
        /// <summary>
        /// Изменение принадлежности станции к какому-то маршруту.
        /// </summary>
        /// <param name="routeId">Номер маршрута.</param>
        /// <returns>Возвращается true, если получилось изменить номер маршрута у станции. В другом случае возвращается false</returns>
        internal bool SetRouteId(Guid routeId)
        {
            if(RouteId == routeId) return false;
            RouteId = routeId;
            return true;
        }
        /// <summary>
        /// Изменение состояния станции.
        /// </summary>
        /// <param name="stationStatus">Состояние станции(активна, заморожена).</param>
        /// <returns>Возвращается true, если получилось изменить состояние у станции. В другом случае возвращается false</returns>
        public bool ChangeStationStatus(StationStatus stationStatus) // internal 
        {
            if (StationStatus == stationStatus) return false;
            StationStatus = stationStatus;
            return true;
        }
        /// <summary>
        /// Изменение тарифной зоны станции.
        /// </summary>
        /// <param name="tariffZone">Номер тарифной зоны.</param>
        /// <returns>Возвращается true, если получилось изменить тарифную зону станции. В другом случае возвращается false</returns>
        public bool SetTariffZone(Guid tariffZone)
        {
            if (TariffZone == tariffZone) return false;
            TariffZone = tariffZone;
            return true;
        }




    }
}
