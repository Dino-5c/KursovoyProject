using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    internal class TicketTypeValidator : IValidator<string>
    {
        public static int MAX_VALUE => 20;

        public static int MIN_VALUE => 5;

        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(ExceptionMessages.TICKET_TYPE_NOT_NULL_OR_WHITE_SPACE, nameof(value)); // С помощью ключевого слова typeof мы получаем тип класса
            if (value.Length > MAX_LENGTH)
                throw new TicketTypeLongValueException(value, MAX_LENGTH);
            if (value.Length < MIN_LENGTH)
                throw new TicketTypeShortValueException(value, MIN_LENGTH);
        }
    }
}
