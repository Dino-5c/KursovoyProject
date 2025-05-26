using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class TicketTypeLongValueException(string ticketTypeName, int maxLength)
        : ArgumentException($"Type of ticket name length {ticketTypeName} greated than maximum allowed length (допустимая длина) {maxLength}") // ArgumentException, Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым. Наследование: Object ==> Exception ==> SystemException ==> ArgumentException
    {
        public string TicketTypeName => ticketTypeName;
        public int MaxLength => maxLength;
    }
}
