using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;

namespace TrainStation.Domain.TrainStation.ValueObjects
{
    internal class TicketType(string ticketType) : ValueObject<string>(new TicketTypeValidator(), ticketType); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его 

}
