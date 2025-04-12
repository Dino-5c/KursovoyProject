using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    internal class RoNameValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 60;

        public static int MIN_LENGTH => 5;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(ExceptionMessages.RO_NAME_NOT_NULL_OR_WHITE_SPACE, nameof(value)); // С помощью ключевого слова typeof мы получаем тип класса
            if (value.Length > MAX_LENGTH)
                throw new RoNameLongValueException(value, MAX_LENGTH);
            if (value.Length < MIN_LENGTH)
                throw new RoNameShortValueException(value, MIN_LENGTH);
        }
    }
}
