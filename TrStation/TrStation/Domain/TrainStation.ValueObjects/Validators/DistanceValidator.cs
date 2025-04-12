using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    internal class DistanceValidator : IValidator<int>
    {
        public void Validate(int value)
        {
            if (value < 0)
                throw new DistanceNonPositiveException(ExceptionMessages.DISTANCE_NON_POSITIVE, nameof(value), value);
        }
    }
}
