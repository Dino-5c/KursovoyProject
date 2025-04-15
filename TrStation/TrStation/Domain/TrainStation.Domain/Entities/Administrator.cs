using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;
using TrStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    public class Administrator(Guid administratorId, LastName administratorLastName, FirstName administratorFirstName) : Entity<Guid>
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

    }
}
