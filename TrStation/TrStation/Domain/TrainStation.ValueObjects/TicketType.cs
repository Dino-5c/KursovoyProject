using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrainStation.Domain.TrainStation.ValueObjects
{
    /// <summary>
    /// Представляет тип названия типа билета
    /// </summary>
    /// <param name="ticketType">Название типа билета</param>
    public class TicketType(string ticketType) : ValueObject<string>(new TicketTypeValidator(), ticketType); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его 

}
