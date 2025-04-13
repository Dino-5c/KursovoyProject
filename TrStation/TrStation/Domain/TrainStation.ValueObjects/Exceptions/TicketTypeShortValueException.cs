using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class TicketTypeShortValueException(string ticketTypeName, int minLength)
        : FormatException($"Type of Ticket name length {ticketTypeName} less than minimum allowed length (допустимая длина) {minLength}") // FormatException. Исключение, которое возникает
                         // в случае, если формат аргумента недопустим или строка составного формата построена неправильно.  Наследование  Object ==> Exception ==> SystemException ==> FormatException
    {
        public string TicketTypeName => ticketTypeName;
        public int MinLength => minLength;
    }
}
