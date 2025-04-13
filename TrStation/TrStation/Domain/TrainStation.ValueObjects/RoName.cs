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
    /// Представляет тип названия маршрута
    /// </summary>
    /// <param name="name">Название маршрута</param>
    public class RoName(string name) : ValueObject<string>(new RoNameValidator(), name); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его 

}
