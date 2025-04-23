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
using TrStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class Administrator(Guid administratorId, LastName administratorLastName, FirstName administratorFirstName) : Entity<Guid>(administratorId)
    {

        public LastName AdministratorLastName { get; private set; } = administratorLastName ?? throw new ArgumentNullValueException(nameof(administratorLastName));

        public FirstName AdministratorFirstName { get; private set; } = administratorFirstName ?? throw new ArgumentNullValueException(nameof(administratorFirstName));

        //public Administrator(Guid administratorId, LastName administratorLastName, FirstName administratorFirstName) : base(administratorId)
        //{
        //    AdministratorLastName = administratorLastName;
        //    AdministratorFirstName = administratorFirstName;
        //}

        public bool SetAdministratorLastName(LastName administratorLastName)
        {
            if (AdministratorLastName == administratorLastName) return false;
            AdministratorLastName = administratorLastName;
            return true;
        }

        public bool SetAdministratorFirstName(FirstName administratorFirstName)
        {
            if (AdministratorFirstName == administratorFirstName) return false;
            AdministratorFirstName = administratorFirstName;
            return true;
        }


        public void TimeTableRedacting(TimeTable timeTable)
        {
            if (timeTable == null) return;
            // Исключение?

            //
            // Выбор, что хотим изменить, отдельные методы для каждого параметра, которое хотим изменить
        }



         public bool SetRouteName(Route route, RoName routeName, Administrator administrator)
        {
            if(!route.SetRouteName(routeName, this))
                return false;
            return true;
        }

        public bool SetStationName(Station station, StationName stationName /*, this */)
        {
            if(!station.SetStationName(stationName, this))
                return false;
            return true;
        }

        public void SetStationStatus(Station station, StationStatus stationStatus)
        {
            station.ChangeStationStatus(stationStatus, this);
        }

        public void ChangeStationTariffZone(Station station, Tariffes tariffZone)
        {
            station.SetTariffZone(tariffZone, this);
        }


    }
}
