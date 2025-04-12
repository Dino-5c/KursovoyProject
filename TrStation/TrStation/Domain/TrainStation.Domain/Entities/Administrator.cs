using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;
using TrStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class Administrator : Entity<Guid>
    {
        public Guid AdministratorId { get; }

        public LastName AdministratorLastName { get; private set; }
        
        public FirstName AdministratorFirstName { get; private set; }

        public Administrator(Guid administratorId, LastName administratorLastName, FirstName administratorFirstName) : base(administratorId)
        {
            AdministratorLastName = administratorLastName;
            AdministratorFirstName = administratorFirstName;
        }

        public void SetAdministratorLastName(LastName administratorLastName)
        {

        }

        public void SetAdministratorFirstName(FirstName administratorFirstName)
        {

        }

    }
}
