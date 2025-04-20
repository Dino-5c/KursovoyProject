using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    public class TrainNumberValidator : IValidator<string>
    {
        public static int MAX_LENGTH => 10;

        public static int MIN_LENGTH => 2;


        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException( ExceptionMessages.TRAIN_NUMBER_NOT_NULL_OR_WHITE_SPACE, nameof(value)); // Nameof Выражение создает имя переменной, типа или элемента в виде строковой константы.
            if (value.Length > MAX_LENGTH)
                throw new TrainNumberLongValueException(value, MAX_LENGTH);
            if (value.Length < MIN_LENGTH)
                throw new TrainNumberShortValueException(value, MIN_LENGTH);

        }

    }
}
