using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class TimeTable 
    {
        public Guid RouteId {get; }
        
        public Guid StationId { get; private set; }

        public TrainNumber NumberOfTrain { get; private set; }
        
        public DateTime TimeArrival { get; private set; }

        public TimeTable(Guid routeId, Guid stationId, TrainNumber numberOfTrain, DateTime timeArrival)
        {
            RouteId = routeId;
            StationId = stationId;
            NumberOfTrain = numberOfTrain;
            TimeArrival = timeArrival;
        }

        /// <summary>
        /// Изменение Станции, с которой отправляется поезд.
        /// </summary>
        /// <param name="stationId">Номер станции.</param>
        /// <returns>Возвращается true, если получилось изменить номер станции. В другом случае возвращается false</returns>
        public bool SetStationId(Guid stationId)
        {
            if (StationId == stationId) return false;
            StationId = stationId;
            return true;
        }

        /// <summary>
        /// Изменение номера поезда.
        /// </summary>
        /// <param name="numberOfTrain">Номер поезда.</param>
        /// <returns>Возвращается true, если получилось изменить номер поезда. В другом случае возвращается false</returns>
        public bool SetNumberOfTrain(TrainNumber numberOfTrain)
        {
            if (NumberOfTrain == numberOfTrain) return false;
            NumberOfTrain = numberOfTrain;
            return true;
        }

    }
}
